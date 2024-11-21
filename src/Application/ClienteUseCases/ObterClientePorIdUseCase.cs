using Domain.Entities.Cliente;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Cliente;

namespace Application.ClienteUseCases
{
    public class ObterClientePorIdUseCase : IObterClientePorIdUseCase
    {
        private readonly IClienteRepository _clienteRepository;
        public ObterClientePorIdUseCase(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public PessoaFisicaEntidade Run(long idCliente)
        {
            return _clienteRepository.ObterClientePorId(idCliente);
        }
    }
}
