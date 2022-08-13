using EnderecoProject.Entities.Base;
using System.Collections.Generic;

namespace EnderecoProject.Entities
{
    /// <summary>
    /// Representa a Cidade.
    /// </summary>
    public class Cidade : ObjetoComNome
    {
        /// <summary>
        /// A lista de bairros da cidade.
        /// </summary>
        public List<Bairro> ListaDeBairros { get; set; }

        /// <summary>
        /// O estado ao qual a cidade pertence.
        /// </summary>
        public Estado Estado { get; set; }
    }
}
