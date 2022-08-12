using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa009.Exercicio2
{
    public class Livro : Produto
    {
        public Livro(string descricao, string autor)
            : base(descricao)
        {
            Autor = autor;
        }
        public string Autor { get; set; }

        public override string GetDescricao()
        {
            return Descricao + " " + Autor;
        }
    }
}
