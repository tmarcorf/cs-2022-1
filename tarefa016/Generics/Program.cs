using System.Runtime.Intrinsics.Arm;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando titulares.
            var titular1 = new Titular(1, "Pedro");
            var titular2 = new Titular(2, "Joana");

            // Criando lista de dependentes.
            var listaDependentes1 = new List<Dependente>
            {
                new Dependente(1, "João Amâncio") ,
                new Dependente (2, "Roger Perez" ),
                new Dependente(3, "Ana Amâncio" )
            };

            var listaDependentes2 = new List<Dependente>
            {
                new Dependente(4, "Júlia Martins") ,
                new Dependente (5, "Felipe Menezes" ),
                new Dependente(6, "Felipe Oliveira" )
            };

            // Adicionando os dependentes aos titulares
            titular1.AdicioneDependentes(listaDependentes1);
            titular2.AdicioneDependentes(listaDependentes2);

            // Obtendo somente os dependentes que possuem "Felipe" no nome.
            var listaDependetesFelipe = titular2.ObtenhaListaDeDependentes().Where(x => x.Nome.Contains("Felipe")).ToList();
            var listaDependentesIdMenorQue3 = titular1.ObtenhaListaDeDependentes().Where(x => x.Id < 3).ToList();

            listaDependetesFelipe.ForEach(dep =>
            {
                Console.WriteLine("Id: {0} | Nome: {1}", dep.Id, dep.Nome);
            });

            Console.WriteLine("==========================");

            listaDependentesIdMenorQue3.ForEach(dep =>
            {
                Console.WriteLine("Id: {0} | Nome: {1}", dep.Id, dep.Nome);
            });
        }
    }
}