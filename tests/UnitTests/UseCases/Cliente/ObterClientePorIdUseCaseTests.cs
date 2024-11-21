using Application.ClienteUseCases;
using Domain.Entities;
using Domain.Entities.Cliente;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Cliente
{
    public class ObterClientePorIdUseCaseTests
    {
        private readonly Mock<IClienteRepository> _clienteRepositoryMock;
        private readonly ObterClientePorIdUseCase _obterClientePorIdUseCase;

        public ObterClientePorIdUseCaseTests()
        {
            _clienteRepositoryMock = new Mock<IClienteRepository>();
            _obterClientePorIdUseCase = new ObterClientePorIdUseCase(_clienteRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldReturnCliente_WhenClienteExists()
        {
            // Arrange
            var idCliente = 1L;
            var expectedCliente = new PessoaFisicaEntidade("John Doe", new EnderecoEntidade(0, "Street", 123, "Apt 1", "Neighborhood", "City", "State", "12345-678"), new ContatoEntidade(0, "123456789", "email@example.com"), new DateOnly(1990, 1, 1));
            _clienteRepositoryMock.Setup(repo => repo.ObterClientePorId(idCliente)).Returns(expectedCliente);

            // Act
            var result = _obterClientePorIdUseCase.Run(idCliente);

            // Assert
            Assert.Equal(expectedCliente, result);
            _clienteRepositoryMock.Verify(repo => repo.ObterClientePorId(idCliente), Times.Once);
        }

        [Fact]
        public void Run_ShouldReturnNull_WhenClienteDoesNotExist()
        {
            // Arrange
            var idCliente = 1L;
            _clienteRepositoryMock.Setup(repo => repo.ObterClientePorId(idCliente)).Returns((PessoaFisicaEntidade)null);

            // Act
            var result = _obterClientePorIdUseCase.Run(idCliente);

            // Assert
            Assert.Null(result);
            _clienteRepositoryMock.Verify(repo => repo.ObterClientePorId(idCliente), Times.Once);
        }
    }
}
