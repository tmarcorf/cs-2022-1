using EnderecoProject.Entities.Base;
using System.Collections.Generic;

namespace EnderecoProject.Entities
{
    public class Estado : ObjetoComNome
    {
        public string Sigla { get; set; }

        public List<Cidade> ListaDeCidades { get; set; }

        public Pais Pais { get; set; }
    }
}
