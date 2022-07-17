namespace Exercicio005
{
    public class Exercicio05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do salário mínimo: ");
            double salarioMinimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do salário de um usuário: ");
            double salarioUsuario = double.Parse(Console.ReadLine());

            Console.WriteLine("O usuário em questão ganha {0} salário(s) mínimo(s).", (salarioUsuario / salarioMinimo));
        }
    }
}