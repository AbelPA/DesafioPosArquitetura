using Application.ProdutoUseCase;
using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Produto
{
    public class ObterTodosOsProdutosUseCaseTests
    {
        private readonly Mock<IProdutoRepository> _produtoRepositoryMock;
        private readonly ObterTodosOsProdutosUseCase _obterTodosOsProdutosUseCase;

        public ObterTodosOsProdutosUseCaseTests()
        {
            _produtoRepositoryMock = new Mock<IProdutoRepository>();
            _obterTodosOsProdutosUseCase = new ObterTodosOsProdutosUseCase(_produtoRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldReturnAllProdutos_WhenProdutosExist()
        {
            // Arrange
            var expectedProdutos = new List<ProdutoEntidade>
            {
                new ProdutoEntidade
                (
                    1,
                    "Produto Teste 1",
                    "Descrição do Produto Teste 1",
                    100.0m,
                    10
                ),
                new ProdutoEntidade
                (
                    2,
                    "Produto Teste 2",
                    "Descrição do Produto Teste 2",
                    200.0m,
                    20
                )
            };
            _produtoRepositoryMock.Setup(repo => repo.ObterTodosOsProdutos()).Returns(expectedProdutos);

            // Act
            var result = _obterTodosOsProdutosUseCase.Run();

            // Assert
            Assert.Equal(expectedProdutos, result);
            _produtoRepositoryMock.Verify(repo => repo.ObterTodosOsProdutos(), Times.Once);
        }

        [Fact]
        public void Run_ShouldReturnEmptyList_WhenNoProdutosExist()
        {
            // Arrange
            var expectedProdutos = new List<ProdutoEntidade>();
            _produtoRepositoryMock.Setup(repo => repo.ObterTodosOsProdutos()).Returns(expectedProdutos);

            // Act
            var result = _obterTodosOsProdutosUseCase.Run();

            // Assert
            Assert.Empty(result);
            _produtoRepositoryMock.Verify(repo => repo.ObterTodosOsProdutos(), Times.Once);
        }
    }
}
