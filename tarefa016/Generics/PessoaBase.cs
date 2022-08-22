using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public abstract class PessoaBase
    {
        public PessoaBase(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
