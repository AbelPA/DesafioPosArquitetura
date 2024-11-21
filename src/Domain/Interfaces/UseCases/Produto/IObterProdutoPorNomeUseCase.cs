using Domain.Entities.Produto;

namespace Domain.Interfaces.UseCases.Produto
{
    public interface IObterProdutoPorNomeUseCase
    {
        public ProdutoEntidade Run(string nomeProduto);
    }
}
