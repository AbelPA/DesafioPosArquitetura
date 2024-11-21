using Domain.Entities.Cliente;
using Domain.Entities.Produto;

namespace Domain.Entities.Pedido
{
    public class PedidoEntidade
    {
        public long Id { get; private set; }
        public DateTime DataPedido { get; private set; }
        public decimal ValorTotal { get; private set; }
        public StatusPedidoEnum Status { get; private set; }
        public PessoaFisicaEntidade Cliente { get; private set; }
        public IEnumerable<ProdutoEntidade> Itens { get; private set; }
        public PagamentoEntidade Pagamento { get; private set; }
        public EnderecoEntidade EnderecoEntrega { get; private set; }

        public PedidoEntidade(long id, DateTime dataPedido, decimal valorTotal, StatusPedidoEnum status,
            PessoaFisicaEntidade cliente, IEnumerable<ProdutoEntidade> itens, PagamentoEntidade pagamento, EnderecoEntidade enderecoEntrega)
        {
            Id = id;
            DataPedido = dataPedido;
            ValorTotal = valorTotal;
            Status = status;
            Cliente = cliente;
            Itens = itens;
            Pagamento = pagamento;
            EnderecoEntrega = enderecoEntrega;
        }
    }
}
