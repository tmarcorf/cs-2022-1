using System.Text.RegularExpressions;

namespace tarefa015
{
    public class Program
    {
        private const string REGEX_EMAIL = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                         + "@"
                                         + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";

        private const string REGEX_SENHA = @"^(?=.*[A-Z])(?=.*[!#@$%&])(?=.*[0-9])(?=.*[a-z]).{8,12}$";

        static void Main(string[] args)
        {
            Console.WriteLine("Insira um e-mail:");
            var email = Console.ReadLine();

            Console.WriteLine(EmailEhValido(email) ? "E-mail válido!" : "E-mail inválido");

            Console.WriteLine("Insira uma senha:");
            var senha = Console.ReadLine();

            Console.WriteLine(SenhaEhValida(senha) ? "Senha válida!" : "Senha inválida");
        }

        private static bool EmailEhValido(string email)
        {
            var regex = new Regex(REGEX_EMAIL);

            return regex.IsMatch(email);
        }

        private static bool SenhaEhValida(string senha)
        { 
            var regex = new Regex(REGEX_SENHA);

            return regex.IsMatch(senha);
        }
    }
}