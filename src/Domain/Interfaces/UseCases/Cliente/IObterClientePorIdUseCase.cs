using Domain.Entities.Cliente;

namespace Domain.Interfaces.UseCases.Cliente
{
    public interface IObterClientePorIdUseCase
    {
        public PessoaFisicaEntidade Run(long idCliente);
    }
}
