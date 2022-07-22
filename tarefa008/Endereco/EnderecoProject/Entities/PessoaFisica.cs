using EnderecoProject.Entities.Base;
using System;

namespace EnderecoProject.Entities
{
    public class PessoaFisica : ObjetoComNome
    {
        public string Sexo { get; set; }

        public DateTime DataNascimento { get; set; }

        public Endereco Endereco { get; set; }
    }
}
