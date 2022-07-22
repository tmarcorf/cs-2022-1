using EnderecoProject.Entities.Base;
using System.Collections.Generic;

namespace EnderecoProject.Entities
{
    public class Bairro : ObjetoComNome
    {
        public List<Endereco> ListaDeEnderecos { get; set; }

        public Cidade Cidade { get; set; }
    }
}
