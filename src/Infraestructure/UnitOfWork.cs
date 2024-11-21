using Domain.Entities.Cliente;
using Domain.Entities.Pedido;
using Domain.Entities.Produto;

namespace Infraestructure
{
    public static class UnitOfWork
    {
        public static List<PessoaFisicaEntidade> Clientes { get; private set; } = new List<PessoaFisicaEntidade>();
        public static List<PedidoEntidade> Pedidos { get; private set; } = new List<PedidoEntidade>();
        public static List<ProdutoEntidade> Produtos { get; private set; } = new List<ProdutoEntidade>();
    }
}
