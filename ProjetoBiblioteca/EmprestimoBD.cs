using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca
{
    class EmprestimoBD
    {
        Conexao banco = new Conexao();

        MySqlConnection con;
        MySqlCommand _cmd;

        public void SalvarEmprestimo(int intIDLeitor, int intIDLivro, string strLeitor, string strLivro, string strRetirada, string strDevolucao)
        {
            con = banco.AbrirConexao();

            string inserir = @"insert into Emprestimo (Id_Leitor, Id_Livro, Leitor, Livro, Retirada, Devolucao) values ('" + intIDLeitor + "','" + intIDLivro + "','" + strLeitor + "','" + strLivro + "','" + strRetirada + "', '" + strDevolucao + "')";

            _cmd = new MySqlCommand(inserir, con);

            // executa o comando

            _cmd.ExecuteNonQuery();

            //Fecha a conexão

            con.Close();
        }

        public MySqlDataAdapter ConsultarEmprestimo(string strLeitor)
        {
            con = banco.AbrirConexao();
            string selecionar;

            selecionar = @"SELECT Leitor, Livro, Retirada, Devolucao, Id_Emprestimo, Id_Leitor, Id_Livro FROM Emprestimo where Leitor like '%" + strLeitor + "%'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(selecionar, con);

            con.Close();
            return adaptador;
        }
        public MySqlDataAdapter ExcluirEmprestimo(int intId)
        {
            con = banco.AbrirConexao();
            string deletar = @"DELETE FROM Emprestimo WHERE Id_Emprestimo=" + intId.ToString() + ";";

            _cmd = new MySqlCommand(deletar, con);

            _cmd.ExecuteNonQuery();

            string selecionar = @"SELECT Id_Emprestimo, Leitor, Livro, Retirada, Devolucao FROM Emprestimo";

            MySqlDataAdapter adapter = new MySqlDataAdapter(selecionar, con);

            con.Close();
            return adapter;
        }
    }
}
