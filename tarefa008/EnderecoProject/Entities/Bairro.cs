using EnderecoProject.Entities.Base;
using System.Collections.Generic;

namespace EnderecoProject.Entities
{
    /// <summary>
    /// Representa o Bairro.
    /// </summary>
    public class Bairro : ObjetoComNome
    {
        /// <summary>
        /// A lista de endereços do bairro.
        /// </summary>
        public List<Endereco> ListaDeEnderecos { get; set; }

        /// <summary>
        /// A cidade a qual o bairro pertence.
        /// </summary>
        public Cidade Cidade { get; set; }
    }
}
