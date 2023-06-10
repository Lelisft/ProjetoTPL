using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ProjetoTPL.Suporte;
using ProjetoTPL.Mapper;

namespace ProjetoTPL
{
    public class UsuarioDAO : Conexao
    {
        public Usuario ValidarLogin(string usuario, string senha)
        {
            return conexao.Query<Usuario>("SELECT * FROM Usuarios WHERE Nome=@Nome AND Senha=@Senha",
            new
            {
                @Nome = usuario,
                @Senha = senha
            }).SingleOrDefault();
        }

        public List<Usuario> BuscarTodos()
        {
            return conexao.Query<Usuario>("SELECT * FROM Usuarios order by Nome").ToList();
        }

        public void Adicionar(string nome, string senha, int ativo)
        {
            conexao.Execute("INSERT INTO Usuarios (Nome, Senha, Ativo) VALUES (@Nome, @Senha, @Ativo)",
            new { nome, senha, ativo });
        }

        public void Atualizar(int id, string nome, string senha, int ativo)
        {
            conexao.Execute("UPDATE Usuarios SET Nome=@Nome, Senha=@Senha, Ativo=@Ativo WHERE ID=@ID",
            new { nome, senha, ativo,  id });
        }

        public void Excluir(int id)
        {
            conexao.Execute("DELETE FROM Usuarios WHERE ID=@ID",
            new { id });
        }
    }
}
