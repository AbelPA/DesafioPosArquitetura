namespace Domain.Entities.Pedido
{
    public class PagamentoEntidade
    {
        public int Id { get; private set; }
        public FormaPagamento FormaPagamento { get; private set; }
        public DateTime DataPagamento { get; private set; }

        public PagamentoEntidade(int id, FormaPagamento formaPagamento, DateTime dataPagamento)
        {
            Id = id;
            FormaPagamento = formaPagamento;
            DataPagamento = dataPagamento;
        }
    }
}
