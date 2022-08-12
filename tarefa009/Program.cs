using tarefa009.Exercicio1;
using tarefa009.Exercicio2;

namespace tarefa009;
class Program
{
    static void Main(string[] args)
    {
        // Exercício 1
        var animalTeste = new AnimalTeste();

        Console.WriteLine("=== Emitindo o som dos animais ===");
        animalTeste.TestarAnimais();
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("=== Exanimando os animais ===");
        animalTeste.ExaminarAnimais();
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("=== Colocando os animais nas jaulas ===");
        animalTeste.ColocarAnimaisNaJaula();
        Console.WriteLine(Environment.NewLine);

        // Exercício 2
        var produtoTeste = new ProdutoTeste();

        produtoTeste.TestarProdutos();
    }
}
