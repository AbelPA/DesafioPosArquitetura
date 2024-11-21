using Application.ProdutoUseCase;
using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Produto
{
    public class AtualizarProdutoUseCaseTests
    {
        private readonly Mock<IProdutoRepository> _produtoRepositoryMock;
        private readonly AtualizarProdutoUseCase _atualizarProdutoUseCase;

        public AtualizarProdutoUseCaseTests()
        {
            _produtoRepositoryMock = new Mock<IProdutoRepository>();
            _atualizarProdutoUseCase = new AtualizarProdutoUseCase(_produtoRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldCallAtualizarProduto_WhenProdutoIsValid()
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
            _atualizarProdutoUseCase.Run(produto);

            // Assert
            _produtoRepositoryMock.Verify(repo => repo.AtualizarProduto(produto), Times.Once);
        }
    }
}
