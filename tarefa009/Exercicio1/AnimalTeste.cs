using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa009.Exercicio1
{
    public class AnimalTeste
    {
        public void TestarAnimais()
        {
            var cachorro = new Cachorro();
            var cavalo = new Cavalo();
            var preguica = new Preguica();

            cachorro.EmitirSom();
            cavalo.EmitirSom();
            preguica.EmitirSom();
        }

        public void ExaminarAnimais()
        {
            var veterinario = new Veterinario();

            var cachorro = new Cachorro();
            var cavalo = new Cavalo();
            var preguica = new Preguica();

            veterinario.Examinar(cachorro);
            veterinario.Examinar(cavalo);
            veterinario.Examinar(preguica);
        }

        public void ColocarAnimaisNaJaula()
        {
            var zoologico = new Zoologico();

            var cachorro1 = new Cachorro();
            var cachorro2 = new Cachorro();
            var cachorro3 = new Cachorro();
            var cachorro4 = new Cachorro();
            var cavalo1 = new Cavalo();
            var cavalo2 = new Cavalo();
            var cavalo3 = new Cavalo();
            var preguica1 = new Preguica();
            var preguica2 = new Preguica();
            var preguica3 = new Preguica();

            zoologico.Jaulas = new Animal[10] { cachorro1, cavalo1, preguica1,
                                                cachorro2, cavalo2, preguica2,
                                                cachorro3, cavalo3, preguica3,
                                                cachorro4 };

            for (int contador = 0; contador < zoologico.Jaulas.Length; contador++)
            {
                var animalAtual = zoologico.Jaulas[contador];

                animalAtual.EmitirSom();

                if (animalAtual is AnimalQueCorre)
                {
                    (animalAtual as AnimalQueCorre).Correr();
                }
            }
        }
    }
}
