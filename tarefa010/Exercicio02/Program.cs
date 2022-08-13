namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var agenda = new Agenda();

            var contato1 = new Contato { Nome = "Fabiana Márcia Fernandes", Email = "fabianamarciafernandes@hotmaill.com" };
            var contato2 = new Contato { Nome = "Daniel Emanuel Benjamin Oliveira", Email = "daniel_oliveira@right.com.br" };
            var contato3 = new Contato { Nome = "Clara Regina Assis", Email = "clara-assis75@dbacomp.com.br" };
            var contato4 = new Contato { Nome = "Murilo Otávio Santos", Email = "murilo_santos@delboux.com.br" };
            var contato5 = new Contato { Nome = "Flávia Priscila Ana Nascimento", Email = "flavia_priscila_nascimento@deskprint.com.br" };

            //Adicionando contatos.
            agenda.AdicionarContato(contato1);
            agenda.AdicionarContato(contato2);
            agenda.AdicionarContato(contato3);
            agenda.AdicionarContato(contato4);
            agenda.AdicionarContato(contato5);

            //Listando contatos.
            agenda.ListarContatos();

            //Buscando contato por nome.
            var contato = agenda.ObtenhaContatoPorNome("Clara Regina Assis");
            Console.WriteLine("Nome: {0} | Email: {1}", contato.Nome, contato.Email + Environment.NewLine);

            //Excluindo um contato
            agenda.ExcluaContato("Murilo Otávio Santos");

            //Listando contatos.
            agenda.ListarContatos();
        }
    }
}