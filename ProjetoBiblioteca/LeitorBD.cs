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
        MySqlCommand _cmd;

        public void SalvarLeitor(string strNome, string strEndereco, int intNumero, string strTelefone, string strCPF)
        {
            con = banco.AbrirConexao();

            string inserir = @"insert into Leitor (Nome, Endereco, Numero, Telefone, CPF) values ('" + strNome + "','" + strEndereco + "','" + intNumero + "','" + strTelefone + "','" + strCPF + "')";

            _cmd = new MySqlCommand(inserir, con);

            // executa o comando

            _cmd.ExecuteNonQuery();

            //Fecha a conexão

            con.Close();
        }

        public MySqlDataAdapter AlterarLeitor(int intId, string strNome, string strEndereco, int intNumero, string strTelefone, string strCPF)
        {
            con = banco.AbrirConexao();

            string alterar = @"UPDATE leitor SET Nome = '" + strNome + "', Endereco = '" + strEndereco + "', Numero = " + intNumero.ToString() + ", Telefone = '" + strTelefone + "', CPF = '" + strCPF + "' WHERE Id_Leitor = " + intId.ToString();

            _cmd = new MySqlCommand(alterar, con);
            _cmd.ExecuteNonQuery();

            string selecionar = @"SELECT Nome, Id_Leitor, Endereco, Numero, Telefone, CPF FROM Leitor";

            MySqlDataAdapter adapter = new MySqlDataAdapter(selecionar, con);

            con.Close();
            return adapter;
        }
        
        public MySqlDataAdapter ConsultarLeitor(string strNome)
        {
            con = banco.AbrirConexao();
            string selecionar;

            selecionar = @"SELECT Nome, Id_Leitor, Endereco, Numero, Telefone, CPF FROM Leitor where Nome like '%" + strNome + "%'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(selecionar, con);

            con.Close();
            return adaptador;
        }
        public MySqlDataAdapter ExcluirLeitor(int codigoLeitor)
        {
            con = banco.AbrirConexao();
            string deletar = @"DELETE FROM Leitor WHERE Id_Leitor='" + codigoLeitor + "';";

            _cmd = new MySqlCommand(deletar, con);

            _cmd.ExecuteNonQuery();

            string selecionar = @"SELECT Nome, Id_Leitor, Endereco, Numero, Telefone, CPF FROM Leitor";

            MySqlDataAdapter adapter = new MySqlDataAdapter(selecionar, con);

            con.Close();
            return adapter;
        }
    }
}