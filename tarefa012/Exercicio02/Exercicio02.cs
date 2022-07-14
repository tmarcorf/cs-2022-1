using java.util;

namespace Exercicio02
{
    public class Exercicio02
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            try
            {
                for (int posicao = 0; posicao < int.MaxValue; posicao++)
                {
                    Console.WriteLine("Digite o valor da posição {0} do vetor.", posicao);
                    int valorDigitado = int.Parse(Console.ReadLine());

                    if (valorDigitado == 0)
                    {
                        break;
                    }

                    vetor[posicao] = valorDigitado;
                }

                for (int posicao = 0; posicao < vetor.Length; posicao++)
                {
                    if (vetor[posicao] != 0)
                    {
                        Console.WriteLine("Elemnto da posição {0}: {1}", posicao, vetor[posicao]);
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Só é possível armazenar até 10 valores.");
            }
            catch (FormatException)
            {
                throw new FormatException("O valor informado não é um inteiro.");
            }
        }
    }
}