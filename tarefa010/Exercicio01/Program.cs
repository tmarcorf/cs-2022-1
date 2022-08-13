using System.Diagnostics;

namespace Exercicio01
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            var vetorDeCem = new int[100];
            var vetorDeMil = new int[1000];
            var vetorDeDezMil = new int[10000];

            PopuleVetor(vetorDeCem);
            PopuleVetor(vetorDeMil);
            PopuleVetor(vetorDeDezMil);

            OrdeneEExibaTempoDeExecucao(vetorDeCem);
            OrdeneEExibaTempoDeExecucao(vetorDeMil);
            OrdeneEExibaTempoDeExecucao(vetorDeDezMil);

            Console.WriteLine("Fim.");
        }

        private static void PopuleVetor(int[] vetor)
        {
            var random = new Random();

            for (int contador = 0; contador < vetor.Length; contador++)
            {
                vetor[contador] = random.Next(vetor.Length);
            }
        }

        private static void OrdeneEExibaTempoDeExecucao(int[] vetor)
        {
            var stopwatch = new Stopwatch();
            var ordenador = new Ordenador();

            Console.WriteLine("=========================");

            stopwatch.Start();
            var vetorResultado = ordenador.MergeSortRecursivo(vetor);
            stopwatch.Stop();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Tempo de execução do vetor de tamanho " + vetorResultado.Length + ": " + stopwatch.ElapsedMilliseconds + "ms");
        }
    }
}