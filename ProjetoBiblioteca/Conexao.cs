using MySql.Data.MySqlClient;
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
        MySqlConnection con;
        public MySqlConnection AbrirConexao()
        {
            con = new MySqlConnection("server=localhost;user id=jrdev;password=Pass*JR;persistsecurityinfo=True;database=bdbiblioteca");
            con.Open();
            return con;
        }

        public void FecharConexao(MySqlConnection con)
        {
            con.Close();
        }
    }
}
