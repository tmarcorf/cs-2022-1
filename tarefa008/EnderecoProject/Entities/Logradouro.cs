using EnderecoProject.Entities.Base;
using EnderecoProject.Entities.Enums;

namespace EnderecoProject.Entities
{
    /// <summary>
    /// Representa o logradouro.
    /// </summary>
    public class Logradouro : ObjetoComNome
    {
        /// <summary>
        /// O tipo de logradouro do logradouro.
        /// </summary>
        public EnumTipoLogradouro TipoDoLogradouro { get; set; }
    }
}
