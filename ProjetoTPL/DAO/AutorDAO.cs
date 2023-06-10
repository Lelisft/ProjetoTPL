using ProjetoTPL.Mapper;
using ProjetoTPL.Suporte;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTPL
{
    public class AutorDAO : Conexao
    {
        public List<Autor> BuscarTodos()
        {
            return conexao.Query<Autor>("SELECT * FROM Autores order by NomeAutor").ToList();
        }

        public Autor BuscarById(int ID)
        {
            return conexao.Query<Autor>("SELECT * FROM Autores WHERE ID=@ID",
            new { ID }).SingleOrDefault();
        }
        public void Adicionar(string nomeAutor)
        {
            conexao.Execute("INSERT INTO Autores (nomeAutor) VALUES (@nomeAutor)",
            new { nomeAutor });
        }

        public void Atualizar(int ID, string nomeAutor)
        {
            conexao.Execute("UPDATE Autores SET NomeAutor=@NomeAutor WHERE ID=@ID",
            new { nomeAutor, ID });
        }

        public void Excluir(int ID)
        {
            conexao.Execute("DELETE FROM Autores WHERE ID=@ID",
            new { ID });
        }

    }
}
