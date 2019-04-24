using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjetoBiblioteca
{
    class LeitorBD
    {
        Conexao banco = new Conexao();

        MySqlConnection con;

        public void SalvarLeitor(string strNome, string strEndereco, int intNumero, string strTelefone, string strCPF)
        {
            con = banco.AbrirConexao();

            string inserir = @"insert into Leitor (Nome, Endereco, Numero, Telefone, CPF) values ('" + strNome + "','" + strEndereco + "','" + intNumero + "','" + strTelefone + "','" + strCPF + "')";

            MySqlCommand _cmd = new MySqlCommand(inserir, con);

            // executa o comando

            _cmd.ExecuteNonQuery();

            //Fecha a conexão

            con.Close();
        }
        public MySqlDataAdapter ConsultarLeitor(string strNome)
        {
            con = banco.AbrirConexao();
            string selecionar;

            selecionar = @"SELECT Nome, Endereco, Numero, Telefone, CPF FROM Leitor where Nome like '%" + strNome + "%'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(selecionar, con);

            con.Close();
            return adaptador;
        }
        public MySqlDataAdapter ExcluirLeitor(string strNome)
        {
            con = banco.AbrirConexao();
            string deletar = @"DELETE FROM Leitor WHERE Nome='" + strNome + "';";

            MySqlCommand _cmd = new MySqlCommand(deletar, con);

            _cmd.ExecuteNonQuery();

            string selecionar = @"SELECT Nome, Endereco, Numero, Telefone, CPF FROM Leitor";

            MySqlDataAdapter adapter = new MySqlDataAdapter(selecionar, con);

            con.Close();
            return adapter;
        }
    }
}