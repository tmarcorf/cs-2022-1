using EnderecoProject.Entities.Base;
using System.Collections.Generic;

namespace EnderecoProject.Entities
{
    /// <summary>
    /// Representa o estado.
    /// </summary>
    public class Estado : ObjetoComNome
    {
        /// <summary>
        /// A sigla do estado.
        /// </summary>
        public string Sigla { get; set; }

        /// <summary>
        /// A lista de cidades  do estado.
        /// </summary>
        public List<Cidade> ListaDeCidades { get; set; }

        /// <summary>
        /// O Pais ao qual o estado pertence.
        /// </summary>
        public Pais Pais { get; set; }
    }
}
