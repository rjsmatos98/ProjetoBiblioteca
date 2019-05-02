using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Livro
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int Paginas { get; set; }
        public int Quantidade { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
