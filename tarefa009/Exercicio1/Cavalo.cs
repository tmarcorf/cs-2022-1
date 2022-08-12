using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tarefa009.Exercicio1
{
    public class Cavalo : AnimalQueCorre
    {
        public override void Correr()
        {
            Console.WriteLine("O cavalo correu!");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Som do cavalo");
        }
    }
}