namespace Exercicio003
{
    internal class Exercicio03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do saldo: ");
            double valorSaldo = double.Parse(Console.ReadLine());

            valorSaldo *= 1.15;

            Console.WriteLine("Saldo reajustado em 15% é: " + valorSaldo);
        }
    }
}