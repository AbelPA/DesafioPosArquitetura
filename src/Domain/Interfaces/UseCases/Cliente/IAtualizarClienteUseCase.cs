using Domain.Entities.Cliente;

namespace Domain.Interfaces.UseCases.Cliente
{
    public interface IAtualizarClienteUseCase
    {
        public void Run(PessoaFisicaEntidade cliente);
    }
}
