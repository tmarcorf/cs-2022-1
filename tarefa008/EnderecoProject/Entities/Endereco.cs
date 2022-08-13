using System.Collections.Generic;

namespace EnderecoProject.Entities
{
    /// <summary>
    /// Representa o Endereço.
    /// </summary>
    public class Endereco
    {
        /// <summary>
        /// O logradouro do endereço.
        /// </summary>
        public Logradouro Logradouro { get; set; }

        /// <summary>
        /// O Numero do endereço.
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// O Complemento do endereço.
        /// </summary>
        public string Complemento { get; set; }

        /// <summary>
        /// O CEP do endereço.
        /// </summary>
        public int CEP { get; set; }

        /// <summary>
        /// A lista de pessoas físicas do endereço.
        /// </summary>
        public List<PessoaFisica> ListaDePessoasFisicas { get; set; }

        /// <summary>
        /// O Bairro do endereço.
        /// </summary>
        public Bairro Bairro { get; set; }
    }
}
