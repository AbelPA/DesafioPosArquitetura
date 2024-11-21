using Domain.Entities.Pedido;

namespace Domain.Interfaces.UseCases.Pedido
{
    public interface IAdicionarPedidoUseCase
    {
        public void Run(PedidoEntidade pedido);
    }
}
