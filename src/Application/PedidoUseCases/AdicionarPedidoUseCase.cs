using Domain.Entities.Pedido;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Pedido;

namespace Application.PedidoUseCases
{
    public class AdicionarPedidoUseCase : IAdicionarPedidoUseCase
    {
        private readonly IPedidosRepository _pedidosRepository;

        public AdicionarPedidoUseCase(IPedidosRepository pedidosRepository)
        {
            _pedidosRepository = pedidosRepository;
        }

        public void Run(PedidoEntidade pedido)
        {
            _pedidosRepository.AdicionarPedido(pedido);
        }
    }
}
