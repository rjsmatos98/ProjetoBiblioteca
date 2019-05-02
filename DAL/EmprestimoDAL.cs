using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class EmprestimoDAL
    {
        Conexao banco = new Conexao();

        MySqlCommand _cmd;

        public void SalvarEmprestimo(Emprestimo emprestimo)
        {
            string insert = @"insert into Emprestimo(Id_Leitor, Id_Livro, Leitor, Livro, Retirada, Devolucao) 
                            values ('" + emprestimo.Leitor.ID.ToString() + "','" + emprestimo.Livro.ID.ToString()
                            + "','" + emprestimo.Leitor.Nome + "', '" + emprestimo.Livro.Nome + "', '" + emprestimo.Retirada
                            + "', '" + emprestimo.Devolucao + "')";

            _cmd = new MySqlCommand(insert, banco.AbrirConexao());
            _cmd.ExecuteNonQuery();
            banco.FecharConexao();
        }

        public List<Emprestimo> ConsultarEmprestimo(string leitor)
        {
            List<Emprestimo> emprestimosList = new List<Emprestimo>();

            string select = @"SELECT ID_EMPRESTIMO, ID_LEITOR, ID_LIVRO, LEITOR, LIVRO, RETIRADA, DEVOLUCAO FROM EMPRESTIMO
                    WHERE LEITOR LIKE '%" + leitor + "%'";

            try
            {
                try
                {
                    _cmd = new MySqlCommand(select, banco.AbrirConexao());

                    MySqlDataReader dr;

                    dr = _cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Emprestimo emprestimo = new Emprestimo
                        {
                            ID = Convert.ToInt32(dr["ID_Emprestimo"]),
                            Leitor = { ID = Convert.ToInt32(dr["ID_Leitor"]), Nome = Convert.ToString(dr["Leitor"]), Endereco = "", Numero = 0, Telefone = "", CPF = "" },
                            Livro = { ID = Convert.ToInt32(dr["ID_Livro"]), Nome = dr["Livro"].ToString() },
                            Retirada = dr["Retirada"].ToString(),
                            Devolucao = dr["Devolucao"].ToString(),
                        };
                        emprestimosList.Add(emprestimo);
                    }
                    return emprestimosList;
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

        public void ExcluirEmprestimo(Emprestimo emprestimo)
        {
            string delete = @"DELETE FROM EMPRESTIMO WHERE ID_EMPRESTIMO = " + emprestimo.ID.ToString() + ";";

            _cmd = new MySqlCommand(delete, banco.AbrirConexao());
            _cmd.ExecuteNonQuery();

            banco.FecharConexao();
        }

        public void SalvarDevolucao(Emprestimo emprestimo)
        {
            string select = @"INSERT INTO DEVOLUCAO(ID_EMPRESTIMO, ID_LEITOR, ID_LIVRO, LEITOR, LIVRO, RETIRADA, DEVOLUCAO) 
                            VALUES(" + emprestimo.ID.ToString() + ", " + emprestimo.Leitor.ID.ToString() + ", " + emprestimo.Livro.ID.ToString()
                            + ", '" + emprestimo.Leitor.Nome + "', '" + emprestimo.Livro.Nome + "', '" + emprestimo.Retirada + "', '" + emprestimo.Devolucao + "')";
            string delete = @"DELETE FROM EMPRESTIMO WHERE ID_EMPRESTIMO = " + emprestimo.ID.ToString() + ";";

            _cmd = new MySqlCommand(select, banco.AbrirConexao());
            _cmd.ExecuteNonQuery();

            _cmd = new MySqlCommand(delete, banco.AbrirConexao());
            _cmd.ExecuteNonQuery();

            banco.FecharConexao();
        }
    }
}
