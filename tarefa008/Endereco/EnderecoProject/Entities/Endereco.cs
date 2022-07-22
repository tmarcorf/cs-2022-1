using System.Collections.Generic;

namespace EnderecoProject.Entities
{
    public class Endereco
    {
        public Logradouro Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public int CEP { get; set; }

        public List<PessoaFisica> ListaDePessoasFisicas { get; set; }

        public Bairro Bairro { get; set; }
    }
}
