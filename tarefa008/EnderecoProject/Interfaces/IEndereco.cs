using EnderecoProject.Entities;

namespace EnderecoProject.Interfaces
{
    /// <summary>
    /// Representa a interface do componente de endereço.
    /// </summary>
    public interface IEndereco
    {
        /// <summary>
        /// Obtém um endereço com base no CEP.
        /// </summary>
        /// <param name="CEP">O CEP informado.</param>
        /// <returns>O Endereço.</returns>
        Endereco ConsultaPorCep(string CEP);
    }
}
