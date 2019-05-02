using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Leitor
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }


        public override string ToString()
        {
            return Nome;
        }
    }
}
