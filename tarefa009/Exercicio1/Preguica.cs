using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tarefa009.Exercicio1
{
    public class Preguica : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Som do preguiça");
        }

        public void SubirNaArvore()
        {
            Console.WriteLine("A preguiça subiu na árvore");
        }
    }
}