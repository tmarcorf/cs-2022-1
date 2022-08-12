using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tarefa009.Exercicio1
{
    public class Cachorro : AnimalQueCorre
    {
        public override void Correr()
        {
            Console.WriteLine("O cachorro correu!");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Som do cachorro");
        }
    }
}