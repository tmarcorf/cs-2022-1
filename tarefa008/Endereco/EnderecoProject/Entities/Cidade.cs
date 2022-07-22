using EnderecoProject.Entities.Base;
using System.Collections.Generic;

namespace EnderecoProject.Entities
{
    public class Cidade : ObjetoComNome
    {
        public List<Bairro> ListaDeBairros { get; set; }

        public Estado Estado { get; set; }
    }
}
