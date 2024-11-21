using Domain.Entities.Pedido;

namespace Domain.Interfaces.Repositories
{
    public interface IPedidosRepository
    {
        public long AdicionarPedido(PedidoEntidade pedido);

        public PedidoEntidade? ObterPedidoPorId(long idPedido);

        public void AtualizarPedido(PedidoEntidade pedido);

        public void RemoverPedido(long idPedido);
    }
}
