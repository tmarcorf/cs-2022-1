using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa009.Exercicio2
{
    public class ProdutoTeste
    {
        public List<Produto> Carrinho { get; set; }

        public void TestarProdutos()
        {
            var livro1 = new Livro("O Poder do Hábito", "Charles Duhigg");
            var livro2 = new Livro("Sapiens: Um Breve História da Humanidade.", "Yuval Harari");

            var mouse1 = new Mouse("Mouse Ótico, USB, 1.600 DPI", "Ótico");
            var mouse2 = new Mouse("Mouse Ótico, USB, 3.200 DPI", "Laser");

            Carrinho = new List<Produto> { livro1, livro2, mouse1, mouse2 };

            Carrinho.ForEach(produto =>
            {
                Console.WriteLine(produto.GetDescricao());
            });
        }
    }
}
