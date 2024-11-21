using Domain.Entities.Cliente;

namespace Domain.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        public long AdicionarCliente(PessoaFisicaEntidade cliente);
        public PessoaFisicaEntidade? ObterClientePorId(long idCliente);
        public void AtualizarCliente(PessoaFisicaEntidade cliente);
        public void RemoverCliente(long idCliente);
    }
}
