namespace Exercicio02
{
    public class Agenda
    {
        private List<Contato> _listaDeContatos { get; set; }

        public Agenda()
        {
            _listaDeContatos = new List<Contato>();
        }

        public void AdicionarContato(Contato contato)
        {
            _listaDeContatos.Add(contato);
        }

        public Contato ObtenhaContatoPorNome(string nome)
        {
            return _listaDeContatos.Where(contato => contato.Nome == nome).FirstOrDefault();
        }

        public Contato ObtenhaContatoPorEmail(string email)
        {
            return _listaDeContatos.Where(contato => contato.Email == email).FirstOrDefault();
        }

        public void ExcluaContato(string nome)
        {
            var contato = ObtenhaContatoPorNome(nome);

            _listaDeContatos.Remove(contato);
        }

        public void ListarContatos()
        {
            _listaDeContatos.ForEach(contato =>
            {
                Console.WriteLine("Nome: {0} | E-mail: {1}", contato.Nome, contato.Email + Environment.NewLine);
            });
        }
    }
}
