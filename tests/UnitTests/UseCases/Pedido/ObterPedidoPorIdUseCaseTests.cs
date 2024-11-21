using Application.PedidoUseCases;
using Domain.Entities;
using Domain.Entities.Cliente;
using Domain.Entities.Pedido;
using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Pedido
{
    public class ObterPedidoPorIdUseCaseTests
    {
        private readonly Mock<IPedidosRepository> _pedidosRepositoryMock;
        private readonly ObterPedidoPorIdUseCase _obterPedidoPorIdUseCase;

        public ObterPedidoPorIdUseCaseTests()
        {
            _pedidosRepositoryMock = new Mock<IPedidosRepository>();
            _obterPedidoPorIdUseCase = new ObterPedidoPorIdUseCase(_pedidosRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldReturnPedido_WhenPedidoExists()
        {
            // Arrange
            var idPedido = 1L;
            var expectedPedido = new PedidoEntidade(idPedido, DateTime.Now, 100.0m, StatusPedidoEnum.AguardandoPagamento,
                new PessoaFisicaEntidade("John Doe", new EnderecoEntidade(0, "Street", 123, "Apt 1", "Neighborhood", "City", "State", "12345-678"),
                new ContatoEntidade(0, "123456789", "email@example.com"), new DateOnly(1990, 1, 1)),
                new List<ProdutoEntidade>(), new PagamentoEntidade(0, FormaPagamento.CartaoCredito, DateTime.Now), new EnderecoEntidade(0, "Street", 123, "Apt 1", "Neighborhood", "City", "State", "12345-678"));
            _pedidosRepositoryMock.Setup(repo => repo.ObterPedidoPorId(idPedido)).Returns(expectedPedido);

            // Act
            var result = _obterPedidoPorIdUseCase.Run(idPedido);

            // Assert
            Assert.Equal(expectedPedido, result);
            _pedidosRepositoryMock.Verify(repo => repo.ObterPedidoPorId(idPedido), Times.Once);
        }

        [Fact]
        public void Run_ShouldReturnNull_WhenPedidoDoesNotExist()
        {
            // Arrange
            var idPedido = 1L;
            _pedidosRepositoryMock.Setup(repo => repo.ObterPedidoPorId(idPedido)).Returns((PedidoEntidade)null);

            // Act
            var result = _obterPedidoPorIdUseCase.Run(idPedido);

            // Assert
            Assert.Null(result);
            _pedidosRepositoryMock.Verify(repo => repo.ObterPedidoPorId(idPedido), Times.Once);
        }
    }
}
