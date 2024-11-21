using Domain.Entities;
using Domain.Entities.Pedido;
using Domain.Entities.Produto;
using WebApi.Model.Pedido;

namespace WebApi.Mappers
{
    public static class PedidoMapper
    {
        public static PedidoEntidade ToEntity(this PedidoModel model)
        {
            return new PedidoEntidade(
                model.Id,
                model.DataPedido,
                model.ValorTotal,
                model.Status,
                PessoaMapper.ToEntity(model.Cliente),
                model.Itens.Select(item => new ProdutoEntidade(
                    item.Id,
                    item.Nome,
                    item.Descricao,
                    item.Preco,
                    item.Estoque
                )).ToList(),
                new PagamentoEntidade
                (
                    model.Pagamento.Id,
                    model.Pagamento.FormaPagamento,
                    model.Pagamento.DataPagamento
                ),
                new EnderecoEntidade(
                    model.EnderecoEntrega.Id,
                    model.EnderecoEntrega.Logradouro,
                    model.EnderecoEntrega.Numero,
                    model.EnderecoEntrega.Complemento,
                    model.EnderecoEntrega.Bairro,
                    model.EnderecoEntrega.Cidade,
                    model.EnderecoEntrega.Estado,
                    model.EnderecoEntrega.Cep
                )
            );
        }
    }
}

