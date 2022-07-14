namespace Exercicio03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Login loginObj = new Login("marco", "956823");

            Console.WriteLine("Informe o usuário");
            string login = Console.ReadLine();

            Console.WriteLine("Informe a senha");
            string senha = Console.ReadLine();

            bool loginFoiRealizado = loginObj.FazerLogin(login, senha);

            if (loginFoiRealizado)
            {
                Console.WriteLine("Login foi realizado com sucesso.");
            }
            else
            {
                throw new LoginInvalidoException("Usuário ou senha incorretos");
            }
        }
    }
}