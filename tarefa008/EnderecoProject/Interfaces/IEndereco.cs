using EnderecoProject.Entities;

namespace EnderecoProject.Interfaces
{
    public interface IEndereco
    {
        Endereco ConsultaPorCep(string CEP);
    }
}
