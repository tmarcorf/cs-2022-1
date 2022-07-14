namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria(5000);

            Console.WriteLine("Informe o valor que deseja sacar");
            double valorParaSaque = double.Parse(Console.ReadLine());

            if (valorParaSaque > conta.Saldo)
            {
                throw new SaldoInsuficienteException("O saldo da conta é insuficiente");
            }
            else
            {
                Console.WriteLine("Saque realizado com sucesso.");
            }
        }
    }
}