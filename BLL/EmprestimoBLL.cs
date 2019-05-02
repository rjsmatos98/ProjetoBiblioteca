using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class EmprestimoBLL
    {
        EmprestimoDAL emprestimoDAL;

        public EmprestimoBLL()
        {
            emprestimoDAL = new EmprestimoDAL();
        }

        public void SalvarEmprestimo(Emprestimo emprestimo)
        {
            emprestimoDAL.SalvarEmprestimo(emprestimo);
        }
        public List<Emprestimo> ConsultarEmprestimo(string leitor)
        {
             return emprestimoDAL.ConsultarEmprestimo(leitor);
        }
        public void ExcluirEmprestimo(Emprestimo emprestimo)
        {
            emprestimoDAL.ExcluirEmprestimo(emprestimo);
        }

        public void SalvarDevolucao(Emprestimo emprestimo)
        {
            emprestimoDAL.SalvarDevolucao(emprestimo);
        }
    }
}
