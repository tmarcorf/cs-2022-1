using EnderecoProject.Entities;
using EnderecoProject.Interfaces;
using System;

namespace EnderecoProject.Persistence
{
    /// <summary>
    /// Representa a implementação do componente de endereço.
    /// </summary>
    public class IEnderecoImpl : IEndereco
    {
        /// <summary>
        /// Obtém um endereço com base no CEP.
        /// </summary>
        /// <param name="CEP">O CEP informado.</param>
        /// <returns>O Endereço.</returns>
        public Endereco ConsultaPorCep(string CEP)
        {
            return new Endereco();
        }
    }
}
