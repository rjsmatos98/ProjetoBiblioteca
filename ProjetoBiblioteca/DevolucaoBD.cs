using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca
{
    class DevolucaoBD
    {
        Conexao banco = new Conexao();

        MySqlConnection con;
        MySqlCommand _cmd;

        public void SalvarDevolucao(int intIDEmprestimo, int intIDLeitor, int intIDLivro, string strLeitor, string strLivro, string strRetirada, string strDevolucao)
        {
            con = banco.AbrirConexao();

            string inserir = @"insert into Devolucao (Id_Emprestimo, Id_Leitor, Id_Livro, Leitor, Livro, Retirada, Devolucao) values ('" + intIDEmprestimo + "','" + intIDLeitor + "','" + intIDLivro + "','" + strLeitor + "','" + strLivro + "', '" + strRetirada + "', '" + strDevolucao + "')";
            string excluir = @"DELETE FROM Emprestimo WHERE Id_Emprestimo='" + intIDEmprestimo + "';";

            _cmd = new MySqlCommand(inserir, con);

            // executa o comando

            _cmd.ExecuteNonQuery();

            _cmd = new MySqlCommand(excluir, con);
            _cmd.ExecuteNonQuery();

            //Fecha a conexão

            con.Close();
        }
    }
}
