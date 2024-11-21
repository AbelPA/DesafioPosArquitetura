using Domain.Entities.Cliente;

namespace Domain.Interfaces.UseCases.Cliente
{
    public interface IAdicionarClienteUseCase
    {
        public long Run(PessoaFisicaEntidade cliente);
    }
}
