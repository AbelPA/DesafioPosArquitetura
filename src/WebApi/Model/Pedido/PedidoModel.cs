using Domain.Entities.Pedido;
using WebApi.Model.Cliente;
using WebApi.Model.Produto;

namespace WebApi.Model.Pedido
{
    public class PedidoModel
    {
        public long Id { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusPedidoEnum Status { get; set; }
        public PessoaModel Cliente { get; set; }
        public IEnumerable<ProdutoModel> Itens { get; set; }
        public PagamentoModel Pagamento { get; set; }
        public EnderecoModel EnderecoEntrega { get; set; }
    }
}
