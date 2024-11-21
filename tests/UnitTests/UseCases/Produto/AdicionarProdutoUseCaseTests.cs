using Application.ProdutoUseCase;
using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Produto
{
    public class AdicionarProdutoUseCaseTests
    {
        private readonly Mock<IProdutoRepository> _produtoRepositoryMock;
        private readonly AdicionarProdutoUseCase _adicionarProdutoUseCase;

        public AdicionarProdutoUseCaseTests()
        {
            _produtoRepositoryMock = new Mock<IProdutoRepository>();
            _adicionarProdutoUseCase = new AdicionarProdutoUseCase(_produtoRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldCallAdicionarProduto_WhenProdutoIsValid()
        {
            // Arrange
            var produto = new ProdutoEntidade
            (
                1,
                "Produto Teste",
                "Descrição do Produto Teste",
                100.0m,
                10
            );

            // Act
            _adicionarProdutoUseCase.Run(produto);

            // Assert
            _produtoRepositoryMock.Verify(repo => repo.AdicionarProduto(produto), Times.Once);
        }
    }
}
