using EnderecoProject.Entities.Base;
using EnderecoProject.Entities.Enums;

namespace EnderecoProject.Entities
{
    public class Logradouro : ObjetoComNome
    {
        public EnumTipoLogradouro TipoDoLogradouro { get; set; }
    }
}
