using Domain.Entities.Pedido;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases.Pedido;

namespace Application.PedidoUseCases
{
    public class ObterPedidoPorIdUseCase : IObterPedidoPorIdUseCase
    {
        private readonly IPedidosRepository _pedidosRepository;
        public ObterPedidoPorIdUseCase(IPedidosRepository pedidosRepository)
        {
            _pedidosRepository = pedidosRepository;
        }
        public PedidoEntidade Run(long idPedido)
        {
            return _pedidosRepository.ObterPedidoPorId(idPedido);
        }
    }
}
