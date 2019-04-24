using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca
{
    class LivroBD
    {
        Conexao banco = new Conexao();

        MySqlConnection con;
        MySqlCommand _cmd;

        public void SalvarLivro(string strNome, string strAutor, string strGenero, int intPaginas, int intQuantidade)
        {
            con = banco.AbrirConexao();


            string inserir = @"insert into Livro (Nome, Autor, Genero, Paginas, Quantidade) 
            values ('" + strNome + "','" + strAutor + "','" + strGenero + "','" + intPaginas 
            + "','" + intQuantidade + "')";

            _cmd = new MySqlCommand(inserir, con);

            // executa o comando

            _cmd.ExecuteNonQuery();

            //Fecha a conexão

            con.Close();
        }
        public MySqlDataAdapter AlterarLivro(int intId, string strNome, string strAutor, string strGenero, int intPaginas, int intQuantidade)
        {
            con = banco.AbrirConexao();

            string alterar = @"UPDATE leitor SET Nome = '" + strNome + "'" +
                ", Autor = '" + strNome + "', Genero = '" + strGenero + "'" +
                ", Paginas = " + intPaginas.ToString() + ", Quantidade = " + intQuantidade.ToString() 
                + " WHERE Id_Livro = " + intId.ToString();

            _cmd = new MySqlCommand(alterar, con);
            _cmd.ExecuteNonQuery();

            string selecionar = @"SELECT Nome, Id_Livro, Autor, Genero, Paginas, Quantidade FROM Livro";

            MySqlDataAdapter adapter = new MySqlDataAdapter(selecionar, con);

            con.Close();
            return adapter;
        }

        public MySqlDataAdapter ConsultarLeitor(string strNome)
        {
            con = banco.AbrirConexao();
            string selecionar;

            selecionar = @"SELECT Nome, Id_Livro, Autor, Genero, Paginas, Quantidade FROM Livro where Nome like '%" + strNome + "%'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(selecionar, con);

            con.Close();
            return adaptador;
        }
        public MySqlDataAdapter ExcluirLeitor(int intId)
        {
            con = banco.AbrirConexao();
            string deletar = @"DELETE FROM Livro WHERE Id_Livro=" + intId.ToString() + ";";

            _cmd = new MySqlCommand(deletar, con);

            _cmd.ExecuteNonQuery();

            string selecionar = @"SELECT Nome, Id_Livro, Autor, Genero, Paginas, Quantidade FROM Livro";

            MySqlDataAdapter adapter = new MySqlDataAdapter(selecionar, con);

            con.Close();
            return adapter;
        }
    }
}
