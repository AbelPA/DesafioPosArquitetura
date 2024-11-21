using Application.ProdutoUseCase;
using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Produto
{
    public class ObterProdutoPorNomeUseCaseTests
    {
        private readonly Mock<IProdutoRepository> _produtoRepositoryMock;
        private readonly ObterProdutoPorNomeUseCase _obterProdutoPorNomeUseCase;

        public ObterProdutoPorNomeUseCaseTests()
        {
            _produtoRepositoryMock = new Mock<IProdutoRepository>();
            _obterProdutoPorNomeUseCase = new ObterProdutoPorNomeUseCase(_produtoRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldReturnProduto_WhenProdutoExists()
        {
            // Arrange
            var nomeProduto = "Produto Teste";
            var expectedProduto = new ProdutoEntidade
            (
                1,
                nomeProduto,
                "Descrição do Produto Teste",
                100.0m,
                10
            );
            _produtoRepositoryMock.Setup(repo => repo.ObterProdutoPorNome(nomeProduto)).Returns(expectedProduto);

            // Act
            var result = _obterProdutoPorNomeUseCase.Run(nomeProduto);

            // Assert
            Assert.Equal(expectedProduto, result);
            _produtoRepositoryMock.Verify(repo => repo.ObterProdutoPorNome(nomeProduto), Times.Once);
        }

        [Fact]
        public void Run_ShouldReturnNull_WhenProdutoDoesNotExist()
        {
            // Arrange
            var nomeProduto = "Produto Inexistente";
            _produtoRepositoryMock.Setup(repo => repo.ObterProdutoPorNome(nomeProduto)).Returns((ProdutoEntidade)null);

            // Act
            var result = _obterProdutoPorNomeUseCase.Run(nomeProduto);

            // Assert
            Assert.Null(result);
            _produtoRepositoryMock.Verify(repo => repo.ObterProdutoPorNome(nomeProduto), Times.Once);
        }
    }
}
