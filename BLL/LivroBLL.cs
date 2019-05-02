using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class LivroBLL
    {
        private LivroDAL livroDAL;

        public LivroBLL()
        {
            livroDAL = new LivroDAL();
        }

        public void SalvarLivro(Livro livro)
        {
            livroDAL.SalvarLivro(livro);
        }
        public void AlterarLivro(Livro livro)
        {
            livroDAL.AlterarLivro(livro);
        }
        public List<Livro> ConsultarLivros(string nome)
        {
            return livroDAL.ConsultarLivros(nome);
        }
        public void ExcluirLIvro(int codigoLivro)
        {
            livroDAL.ExcluirLivro(codigoLivro);
        }
    }
}
