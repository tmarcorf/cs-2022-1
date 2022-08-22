using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Class
{
    public class Endereco
    {
        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string ObtenhaEnderecoCompleto()
        {
            return Logradouro + ", " +
                   Numero + ", " +
                   Bairro + ", " +
                   Cidade + ", " +
                   Estado;
        }
    }
}
