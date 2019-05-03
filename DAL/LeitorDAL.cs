using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class LeitorDAL
    {
        Conexao banco = new Conexao();

        MySqlCommand _cmd;

        public void SalvarLeitor(Leitor leitor)
        {
            string inserir = @"insert into Leitor (Nome, Endereco, Numero, Telefone, CPF) values ('" + leitor.Nome + "','" + leitor.Endereco + "','" + leitor.Numero + "','" + leitor.Telefone + "','" + leitor.CPF + "')";

            _cmd = new MySqlCommand(inserir, banco.AbrirConexao());

            // executa o comando

            _cmd.ExecuteNonQuery();

            //Fecha a conexão

            banco.FecharConexao();
        }

        public void AlterarLeitor(Leitor leitor)
        {
            string alterar = @"UPDATE leitor SET Nome = '" + leitor.Nome + "', Endereco = '" + leitor.Endereco + "', Numero = " + leitor.Numero.ToString() + ", Telefone = '" + leitor.Telefone + "', CPF = '" + leitor.CPF + "' WHERE Id_Leitor = " + leitor.ID.ToString();

            _cmd = new MySqlCommand(alterar, banco.AbrirConexao());
            _cmd.ExecuteNonQuery();

            //string selecionar = @"SELECT  Id_Leitor, Nome, Endereco, Numero, Telefone, CPF FROM Leitor";

            ConsultarLeitor(leitor.Nome);

            //MySqlDataAdapter adapter = new MySqlDataAdapter(selecionar, banco.AbrirConexao());

            banco.FecharConexao();
            //return adapter;
        }

        public List<Leitor> ConsultarLeitor(string strNome)
        {
            //con = banco.AbrirConexao();
            string selecionar;

            //selecionar = @"SELECT Nome, Id_Leitor, Endereco, Numero, Telefone, CPF FROM Leitor where Nome like '%" + strNome + "%'";
            //MySqlDataAdapter adaptador = new MySqlDataAdapter(selecionar, con);

            //con.Close();
            //return adaptador;

            List<Leitor> leitores = new List<Leitor>();

            try
            {
                try
                {
                    selecionar = @"SELECT Id_Leitor, Nome, Endereco, Numero, Telefone, CPF FROM Leitor where Nome like '%" + strNome + "%'";

                    MySqlCommand comando = new MySqlCommand(selecionar, banco.AbrirConexao());

                    MySqlDataReader dr;

                    

                    dr = comando.ExecuteReader();

                    while (dr.Read())
                    {
                        Leitor leitor = new Leitor
                        {
                            ID = Convert.ToInt32(dr["Id_Leitor"]),
                            Nome = dr["Nome"].ToString(),
                            Endereco = dr["Endereco"].ToString(),
                            Numero = Convert.ToInt32(dr["Numero"]),
                            Telefone = dr["Telefone"].ToString(),
                            CPF = dr["CPF"].ToString()
                        };


                        leitores.Add(leitor);

                    }
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

            return leitores;
        }
        public void ExcluirLeitor(int codigoLeitor)
        {
            try
            {
                string deletar = @"DELETE FROM Leitor WHERE Id_Leitor='" + codigoLeitor + "';";

                _cmd = new MySqlCommand(deletar, banco.AbrirConexao());

                _cmd.ExecuteNonQuery();

                banco.FecharConexao();
            }
            catch (MySqlException)
            {
                MessageBox.Show("O leitor selecionado tem emprestimos pendentes!");
            }
        }
    }
}
