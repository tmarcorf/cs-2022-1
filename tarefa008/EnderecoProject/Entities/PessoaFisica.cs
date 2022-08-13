using EnderecoProject.Entities.Base;
using System;

namespace EnderecoProject.Entities
{
    /// <summary>
    /// Representa a pessoa física.
    /// </summary>
    public class PessoaFisica : ObjetoComNome
    {
        /// <summary>
        /// O sexo da pessoa.
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// A data de nascimento da pessoa.
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// O endereço da pessoa.
        /// </summary>
        public Endereco Endereco { get; set; }
    }
}
