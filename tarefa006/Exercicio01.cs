namespace Exercicio001
{
    public class Exercicio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de anos:");
            int qtdeAnos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de meses:");
            int qtdeMeses = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de dias:");
            int qtdeDias = int.Parse(Console.ReadLine());

            int idadeEmDias =ObtenhaAnosEmDias(qtdeAnos) +
                ObtenhaMesesEmDias(qtdeMeses) +
                qtdeDias;

            Console.WriteLine("A idade em dias é: " + idadeEmDias);
        }

        private static int ObtenhaAnosEmDias(int qtdeAnos)
        {
            return qtdeAnos * 365;
        }

        private static int ObtenhaMesesEmDias(int qtdeMeses)
        {
            return qtdeMeses * 30;
        }
    }
}