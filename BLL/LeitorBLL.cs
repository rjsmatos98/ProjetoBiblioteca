using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class LeitorBLL
    {
        private LeitorDAL leitorDAL;
        public LeitorBLL()
        {
            leitorDAL = new LeitorDAL();
        }
        public void IncluirLeitor(Leitor leitor)
        {
            leitorDAL.SalvarLeitor(leitor);
        }

        public void AtualizarLeitor(Leitor leitor)
        {
            leitorDAL.AlterarLeitor(leitor);
        }

        public List<Leitor> ConsultarLeitor(string nome)
        {
            return leitorDAL.ConsultarLeitor(nome);
        }

        public void ExcluirLeitor(int codigo)
        {
            leitorDAL.ExcluirLeitor(codigo);
        }
    }
}
