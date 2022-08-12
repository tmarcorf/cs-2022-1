using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa009.Exercicio2
{
    public class Mouse : Produto
    {
        public Mouse(string descricao, string tipo)
            : base(descricao)
        {
            Tipo = tipo;
        }

        public string Tipo { get; set; }

        public override string GetDescricao()
        {
            return Descricao + " " + Tipo;
        }
    }
}
