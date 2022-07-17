namespace Exercicio004
{
    public class Peca
    { 
        public int Codigo { get; set; }

        public double ValorUnitario { get; set; }

        public int Quantidade { get; set; }
    }

    public class Exercicio04
    {
        static void Main(string[] args)
        {
            Peca peca1 = new Peca();
            Peca peca2 = new Peca();

            Console.WriteLine("Informe a porcentagem do IPI a ser acrescido: ");
            double porcentagemIpi = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código da peça 1: ");
            peca1.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário da peça 1: ");
            peca1.ValorUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade da peça 1: ");
            peca1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código da peça 2: ");
            peca2.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário da peça 2: ");
            peca2.ValorUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade da peça 2: ");
            peca2.Quantidade = int.Parse(Console.ReadLine());

            double valorTotalPeca1 = (peca1.ValorUnitario * peca1.Quantidade) + (porcentagemIpi);
            double valorTotalPeca2 = (peca2.ValorUnitario * peca2.Quantidade);

            double valorTotal = ((valorTotalPeca1 + valorTotalPeca2) * (porcentagemIpi / 100 + 1) + valorTotalPeca2) * (porcentagemIpi / 100 + 1);

            Console.WriteLine("Valor total das duas peças é: " + valorTotal);
        }
    }
}