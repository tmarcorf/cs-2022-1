using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Ordenador
    {
        public TimeSpan TempoDeExecucao { get; set; }

        public int[] MergeSortRecursivo(int[] vetor)
        {
            int[] vetorEsquerda;
            int[] vetorDireita;
            int[] vetorResultado = new int[vetor.Length];

            if (vetor.Length <= 1)
            {
                return vetor;
            }

            int metade = vetor.Length / 2;
            vetorEsquerda = new int[metade];

            if (vetor.Length % 2 == 0)
            {
                vetorDireita = new int[metade];
            }
            else
            { 
                vetorDireita = new int[metade + 1];
            }

            for (int i = 0; i < metade; i++)
            { 
                vetorEsquerda[i] = vetor[i];
            }

            int x = 0;
            
            for (int i = metade; i < vetor.Length; i++)
            {
                vetorDireita[x] = vetor[i];
                x++;
            }

            vetorEsquerda = MergeSortRecursivo(vetorEsquerda);
            vetorDireita = MergeSortRecursivo(vetorDireita);

            vetorResultado = Merge(vetorEsquerda, vetorDireita);
            return vetorResultado;
        }

        private int[] Merge(int[] vetorEsquerda, int[] vetorDireita)
        {
            int tamanhoResultado = vetorDireita.Length + vetorEsquerda.Length;
            int[] vetorResultado = new int[tamanhoResultado];
            
            int indiceEsquerda = 0, indiceDireita = 0, indiceResultado = 0;
            
            while (indiceEsquerda < vetorEsquerda.Length || indiceDireita < vetorDireita.Length)
            {
                if (indiceEsquerda < vetorEsquerda.Length && indiceDireita < vetorDireita.Length)
                {
                    if (vetorEsquerda[indiceEsquerda] <= vetorDireita[indiceDireita])
                    {
                        vetorResultado[indiceResultado] = vetorEsquerda[indiceEsquerda];
                        indiceEsquerda++;
                        indiceResultado++;
                    }
                    else
                    {
                        vetorResultado[indiceResultado] = vetorDireita[indiceDireita];
                        indiceDireita++;
                        indiceResultado++;
                    }
                }
                else if (indiceEsquerda < vetorEsquerda.Length)
                {
                    vetorResultado[indiceResultado] = vetorEsquerda[indiceEsquerda];
                    indiceEsquerda++;
                    indiceResultado++;
                }
                else if (indiceDireita < vetorDireita.Length)
                {
                    vetorResultado[indiceResultado] = vetorDireita[indiceDireita];
                    indiceDireita++;
                    indiceResultado++;
                }
            }
            return vetorResultado;
        }
    }
}
