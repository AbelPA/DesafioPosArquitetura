using Domain.Entities.Pedido;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Pedido;

namespace Application.PedidoUseCases
{
    public class AtualizarPedidoUseCase : IAtualizarPedidoUseCase
    {
        private readonly IPedidosRepository _pedidosRepository;

        public AtualizarPedidoUseCase(IPedidosRepository pedidosRepository)
        {
            _pedidosRepository = pedidosRepository;
        }

        public void Run(PedidoEntidade pedido)
        {
            _pedidosRepository.AtualizarPedido(pedido);
        }
    }
}
