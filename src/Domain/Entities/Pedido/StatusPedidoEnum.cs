namespace Domain.Entities.Pedido
{
    public enum StatusPedidoEnum
    {
        AguardandoPagamento,
        PagamentoConfirmado,
        EmPreparo,
        Enviado,
        Entregue,
        Cancelado
    }
}
