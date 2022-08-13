using EnderecoProject.Entities.Base;
using System.Collections.Generic;

namespace EnderecoProject.Entities
{
    /// <summary>
    /// Representa o País.
    /// </summary>
    public class Pais : ObjetoComNome
    {
        /// <summary>
        /// A lista de estados do país.
        /// </summary>
        public List<Estado> ListaDeEstados { get; set; }
    }
}
