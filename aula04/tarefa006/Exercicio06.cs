namespace Exercicio006
{
    public class Exercicio06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro: ");
            int inteiro = int.Parse(Console.ReadLine());

            Console.WriteLine("O antecessor de {0} é {1} e o sucessor é {2}", inteiro, (inteiro - 1), (inteiro + 1));
        }
    }
}