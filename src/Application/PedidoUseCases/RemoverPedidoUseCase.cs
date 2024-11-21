using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Pedido;

namespace Application.PedidoUseCases
{
    public class RemoverPedidoUseCase : IRemoverPedidoUseCase
    {
        private readonly IPedidosRepository _pedidosRepository;
        public RemoverPedidoUseCase(IPedidosRepository pedidosRepository)
        {
            _pedidosRepository = pedidosRepository;
        }
        public void Run(long idPedido)
        {
            _pedidosRepository.RemoverPedido(idPedido);
        }
    }
}
