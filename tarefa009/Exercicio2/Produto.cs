using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa009.Exercicio2
{
    public abstract class Produto
    {
        public Produto(string descricao)
        {
            Descricao = descricao;
        }

        public string NomeLoja { get; set; }

        public double Preco { get; set; }

        public string Descricao { get; set; }

        public virtual string GetDescricao()
        {
            return "Produto de informática";
        }
    }
}
