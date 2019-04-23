using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca
{
    class Conexao
    {
        SqlConnection con;
        public SqlConnection AbrirConexao()
        {
            con = new SqlConnection
            {
                ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Dados Pessoais\Desktop\Udemy\C# Essencial\Biblioteca\ProjetoBiblioteca\ProjetoBiblioteca\bdbiblioteca.mdf;Integrated Security=True;Connect Timeout=30"
            };
            con.Open();
            return con;
        }

        public void FecharConexao(SqlConnection con)
        {
            con.Close();
        }

    }
}
