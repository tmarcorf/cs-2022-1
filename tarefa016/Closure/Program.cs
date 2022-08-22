namespace Closure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto { Nome = "GeForce RTX 3060", ValorUnitario = 2926m, Quantidade = 215 };

            CalculeValorDoEstoque(produto);
        }

        private static void CalculeValorDoEstoque(Produto produto)
        { 
            decimal CalculeEstoque(Produto produto)
            {
                return produto.ValorUnitario * produto.Quantidade;
            }

            Console.WriteLine("Valor do estoque de {0}: {1}", produto.Nome, CalculeEstoque(produto));
        }
    }
}