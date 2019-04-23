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


            string inserir = @"insert into Leitor (Nome, Endereco, Numero, Telefone, CPF) values ('" + strNome + "','" + strEndereco + "','" + intNumero + "','" + strCPF + "','" + strTelefone + "')";


            MySqlCommand _cmd = new MySqlCommand(inserir, con);

            // executa o comando

            _cmd.ExecuteNonQuery();

            //Fecha a conexão

            con.Close();
        }
    }
}