using Domain.Entities.Cliente;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Cliente;

namespace Application.ClienteUseCases
{
    public class AtualizarClienteUseCase : IAtualizarClienteUseCase
    {
        private readonly IClienteRepository _clienteRepository;

        public AtualizarClienteUseCase(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Run(PessoaFisicaEntidade cliente)
        {
            _clienteRepository.AtualizarCliente(cliente);
        }
    }
}
