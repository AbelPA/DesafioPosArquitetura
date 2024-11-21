using Domain.Entities.Pedido;
using Domain.Interfaces.Repositories;

namespace Infraestructure
{
    public class PedidosRepository : IPedidosRepository
    {
        private static List<PedidoEntidade> Pedidos = UnitOfWork.Pedidos;

        public long AdicionarPedido(PedidoEntidade pedido)
        {
            var idPedido = Pedidos.Count + 1;
            Pedidos.Add(pedido);
            return idPedido;
        }

        public PedidoEntidade? ObterPedidoPorId(long idPedido)
        {
            return Pedidos.FirstOrDefault(p => p.Id == idPedido);
        }

        public void AtualizarPedido(PedidoEntidade pedido)
        {
            var pedidoExistente = Pedidos.FirstOrDefault(p => p.Id == pedido.Id);
            if (pedidoExistente != null)
            {
                Pedidos.Remove(pedidoExistente);
                Pedidos.Add(pedido);
            }
        }

        public void RemoverPedido(long idPedido)
        {
            var pedidoExistente = Pedidos.FirstOrDefault(p => p.Id == idPedido);
            if (pedidoExistente != null)
            {
                Pedidos.Remove(pedidoExistente);
            }
        }
    }
}
