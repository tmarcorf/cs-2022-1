using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Dependente : PessoaBase
    {
        public Dependente(int id, string nome) : 
            base(id, nome)
        {
        }

        public int IdTitular { get; set; }
    }
}
