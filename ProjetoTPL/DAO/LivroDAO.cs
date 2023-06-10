using Dapper;
using ProjetoTPL.Mapper;
using ProjetoTPL.Suporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTPL
{
    public class LivroDAO : Conexao
    {
        public List<Livro> BuscarTodos()
        {
            return conexao.Query<Livro>("SELECT * FROM Livros order by NomeLivro").ToList();
        }

        public Livro BuscarById(int ID)
        {
            return conexao.Query<Livro>("SELECT * FROM Livros WHERE ID=@ID",
            new { ID }).SingleOrDefault();
        }
        public void Adicionar(int idAutor, string nomeLivro, string genero)
        {
            conexao.Execute("INSERT INTO Livros (IDAutor, NomeLivro, Genero) VALUES (@IDAutor, @NomeLivro, @Genero)",
            new { idAutor, nomeLivro, genero });
        }

        public void Atualizar(int ID, string idAutor, string nomeLivro, string genero)
        {
            conexao.Execute("UPDATE Livros SET IDAutor=@IDAutor, NomeLivro=@NomeLivro, Genero=@Genero WHERE ID=@ID",
            new { idAutor, nomeLivro, genero, ID });
        }

        public void Excluir(int ID)
        {
            conexao.Execute("DELETE FROM Livros WHERE ID=@ID",
            new { ID });
        }
    }
}
