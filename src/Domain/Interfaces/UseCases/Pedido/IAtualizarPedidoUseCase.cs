using Domain.Entities.Pedido;

namespace Domain.Interfaces.UseCases.Pedido
{
    public interface IAtualizarPedidoUseCase
    {
        public void Run(PedidoEntidade pedido);
    }
}
