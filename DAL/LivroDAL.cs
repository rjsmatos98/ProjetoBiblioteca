using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class LivroDAL
    {
        Conexao banco = new Conexao();

        MySqlCommand _cmd;

        public void SalvarLivro(Livro livro)
        {
            string insert = @"insert into Livro (Nome, Autor, Genero, Paginas, Quantidade) values ('" + livro.Nome + "','" + livro.Autor + "','" + livro.Genero + "','" + livro.Paginas.ToString() + "','" + livro.Quantidade.ToString() + "')";

            _cmd = new MySqlCommand(insert, banco.AbrirConexao());

            _cmd.ExecuteNonQuery();

            banco.FecharConexao();
        }
        public void AlterarLivro(Livro livro)
        {
            string update = @"Update livro SET Nome = '" + livro.Nome + "', Autor = '" + livro.Autor + "', Genero = '" + livro.Genero + "', Paginas = " + livro.Paginas.ToString() + ", Quantidade = " + livro.Quantidade + " WHERE Id_Livro = " + livro.ID.ToString();

            _cmd = new MySqlCommand(update, banco.AbrirConexao());

            _cmd.ExecuteNonQuery();

            banco.FecharConexao();
        }
        public List<Livro> ConsultarLivros(string nome)
        {
            string select = @"Select ID_Livro, Nome, Autor, Genero, Paginas, Quantidade FROM Livro WHERE Nome like '%" + nome +"%'";
            List<Livro> livros = new List<Livro>();

            try
            {
                try
                {
                    _cmd = new MySqlCommand(select, banco.AbrirConexao());

                    MySqlDataReader dr;

                    dr = _cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Livro livro = new Livro
                        {
                            ID = Convert.ToInt32(dr["Id_Livro"]),
                            Nome = dr["Nome"].ToString(),
                            Autor = dr["Autor"].ToString(),
                            Genero = dr["Genero"].ToString(),
                            Paginas = Convert.ToInt32(dr["Paginas"]),
                            Quantidade = Convert.ToInt32(dr["Quantidade"])
                        };

                        livros.Add(livro);
                    }
                    return livros;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            finally
            {
                banco.FecharConexao();
            }
        }
        public void ExcluirLivro(int codigoLivro)
        {
            string delete = @"DELETE FROM Livro WHERE Id_Livro = " + codigoLivro.ToString();

            _cmd = new MySqlCommand(delete, banco.AbrirConexao());
            _cmd.ExecuteNonQuery();

            banco.FecharConexao();
        }
    }
}
