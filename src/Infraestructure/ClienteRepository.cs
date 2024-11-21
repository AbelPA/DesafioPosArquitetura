using Domain.Entities.Cliente;
using Domain.Interfaces.Repositories;

namespace Infraestructure
{
    public class ClienteRepository : IClienteRepository
    {
        private static List<PessoaFisicaEntidade> ClientesPessoasFisicas = UnitOfWork.Clientes;

        public long AdicionarCliente(PessoaFisicaEntidade cliente)
        {
            var idCliente = ClientesPessoasFisicas.Count + 1;

            cliente.AdicionarIdPessoaFisica(idCliente);
            ClientesPessoasFisicas.Add(cliente);

            return idCliente;
        }

        public PessoaFisicaEntidade? ObterClientePorId(long idCliente)
        {
            return ClientesPessoasFisicas.FirstOrDefault(c => c.Id == idCliente);
        }

        public void AtualizarCliente(PessoaFisicaEntidade cliente)
        {
            var clienteExistente = ClientesPessoasFisicas.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteExistente != null)
            {
                ClientesPessoasFisicas.Remove(clienteExistente);
                ClientesPessoasFisicas.Add(cliente);
            }
        }

        public void RemoverCliente(long idCliente)
        {
            var clienteExistente = ClientesPessoasFisicas.FirstOrDefault(c => c.Id == idCliente);
            if (clienteExistente != null)
            {
                ClientesPessoasFisicas.Remove(clienteExistente);
            }
        }
    }
}
