using Domain.Entities.Cliente;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Cliente;

namespace Application.ClienteUseCases
{
    public class AdicionarClienteUseCase : IAdicionarClienteUseCase
    {
        private readonly IClienteRepository _clienteRepository;

        public AdicionarClienteUseCase(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public long Run(PessoaFisicaEntidade cliente)
        {
            return _clienteRepository.AdicionarCliente(cliente);
        }
    }
}
