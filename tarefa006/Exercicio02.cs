namespace Exercicio002
{
    public class Exercicio02
    {
        static void Main(string[] args)
        {
            // * imprima a média aritmética dos números 8,9 e 7.
            int mediaAritmetica1 = (8 + 9 + 7) / 3;
            Console.WriteLine("Média aritmética de 8, 9 e 7 é: " + mediaAritmetica1);

            // *A média dos números 4, 5 e 6.
            int mediaAritmetica2 = (4 + 5 + 6) / 3;
            Console.WriteLine("Média aritmética de 4, 5 e 6 é: " + mediaAritmetica2);

            // * A soma das duas médias.
            Console.WriteLine("A soma das médias é: " + (mediaAritmetica1 + mediaAritmetica2));

            // * A média das médias.
            int mediaDasDuasMedias = (mediaAritmetica1 + mediaAritmetica2) / 2;
            Console.WriteLine("A média das duas médias é: " + mediaDasDuasMedias);
        }
    }
}