using Java.util;

namespace Tarefa12
{
    public class DivisorDeNumeros
    {
        public int PrimeiroNumero { get; set; }
        public int SegundoNumero { get; set; }
		
        public DivisorDeNumeros(int primeiroNumero, int segundoNumero)
        {
            PrimeiroNumero = primeiroNumero;
            SegundoNumero = segundoNumero;
        }

        public int RealizeDivisaoDeNumeros()
        {
	        return (PrimeiroNumero / SegundoNumero);
        }
	}

    public class Exercicio01
    {
        static void Main(string[] args)
        {
            DivisorDeNumeros divisor = new DivisorDeNumeros(20, 0);

            try
            {
                int resultado = divisor.RealizeDivisaoDeNumeros();
                Console.Write("O resultado é: " + resultado);
            }
            catch (DivideByZeroException)
            {
                throw new ArithmeticException("Não é possível dividir um número por 0.");
            }
            catch (InputMismatchException)
            {
                throw new InputMismatchException("O valor informado não é numérico");
            }
        }
    }
}
