﻿using Application.PedidoUseCases;
using Domain.Entities;
using Domain.Entities.Cliente;
using Domain.Entities.Pedido;
using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;
using Moq;

namespace UnitTests.UseCases.Pedido
{
    public class AtualizarPedidoUseCaseTests
    {
        private readonly Mock<IPedidosRepository> _pedidosRepositoryMock;
        private readonly AtualizarPedidoUseCase _atualizarPedidoUseCase;

        public AtualizarPedidoUseCaseTests()
        {
            _pedidosRepositoryMock = new Mock<IPedidosRepository>();
            _atualizarPedidoUseCase = new AtualizarPedidoUseCase(_pedidosRepositoryMock.Object);
        }

        [Fact]
        public void Run_ShouldCallAtualizarPedido_WhenPedidoIsValid()
        {
            // Arrange
            var pedido = new PedidoEntidade(1, DateTime.Now, 100.0m, StatusPedidoEnum.AguardandoPagamento,
                new PessoaFisicaEntidade("John Doe", new EnderecoEntidade(0, "Street", 123, "Apt 1", "Neighborhood", "City", "State", "12345-678"),
                new ContatoEntidade(0, "123456789", "email@example.com"), new DateOnly(1990, 1, 1)),
                new List<ProdutoEntidade>(), new PagamentoEntidade(0, FormaPagamento.Boleto, DateTime.Now), new EnderecoEntidade(0, "Street", 123, "Apt 1", "Neighborhood", "City", "State", "12345-678"));

            // Act
            _atualizarPedidoUseCase.Run(pedido);

            // Assert
            _pedidosRepositoryMock.Verify(repo => repo.AtualizarPedido(pedido), Times.Once);
        }
    }
}
