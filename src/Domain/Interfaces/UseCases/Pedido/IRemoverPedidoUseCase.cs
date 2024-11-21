namespace Domain.Interfaces.UseCases.Pedido
{
    public interface IRemoverPedidoUseCase
    {
        public void Run(long idPedido);
    }
}
