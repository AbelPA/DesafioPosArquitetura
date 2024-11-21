using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Cliente;

namespace Application.ClienteUseCases
{
    public class RemoverClienteUseCase : IRemoverClienteUseCase
    {
        private readonly IClienteRepository _clienteRepository;

        public RemoverClienteUseCase(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Run(long idCliente)
        {
            _clienteRepository.RemoverCliente(idCliente);
        }
    }
}
