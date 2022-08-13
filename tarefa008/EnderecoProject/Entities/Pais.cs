using EnderecoProject.Entities.Base;
using System.Collections.Generic;

namespace EnderecoProject.Entities
{
    public class Pais : ObjetoComNome
    {
        public List<Estado> ListaDeEstados { get; set; }
    }
}
