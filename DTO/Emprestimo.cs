using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Emprestimo
    {
        public int ID { get; set; }
        public Leitor Leitor { get; set; }
        public Livro Livro { get; set; }
        public string Retirada { get; set; }
        public string Devolucao { get; set; }

        public Emprestimo()
        {
            Leitor = new Leitor {};
            Livro = new Livro { };
        }
    }
}
