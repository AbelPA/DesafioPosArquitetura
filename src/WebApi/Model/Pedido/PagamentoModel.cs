using Domain.Entities.Pedido;

namespace WebApi.Model.Pedido
{
    public class PagamentoModel
    {
        public int Id { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}
