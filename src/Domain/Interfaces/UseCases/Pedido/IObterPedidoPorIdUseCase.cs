using Domain.Entities.Pedido;

namespace Domain.Interfaces.UseCases.Pedido
{
    public interface IObterPedidoPorIdUseCase
    {
        public PedidoEntidade Run(long idPedido);
    }
}