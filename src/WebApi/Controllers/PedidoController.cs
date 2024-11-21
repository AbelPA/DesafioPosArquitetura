using Domain.Interfaces.UseCases.Pedido;
using Microsoft.AspNetCore.Mvc;
using WebApi.Mappers;
using WebApi.Model.Pedido;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IAdicionarPedidoUseCase _adicionarPedidoUseCase;
        private readonly IAtualizarPedidoUseCase _atualizarPedidoUseCase;
        private readonly IRemoverPedidoUseCase _removerPedidoUseCase;
        private readonly IObterPedidoPorIdUseCase _obterPedidoPorIdUseCase;

        public PedidoController(IAdicionarPedidoUseCase adicionarPedidoUseCase, IAtualizarPedidoUseCase atualizarPedidoUseCase, IRemoverPedidoUseCase removerPedidoUseCase, IObterPedidoPorIdUseCase obterPedidoPorIdUseCase)
        {
            _adicionarPedidoUseCase = adicionarPedidoUseCase;
            _atualizarPedidoUseCase = atualizarPedidoUseCase;
            _removerPedidoUseCase = removerPedidoUseCase;
            _obterPedidoPorIdUseCase = obterPedidoPorIdUseCase;
        }

        [HttpPost]
        public IActionResult AdicionarPedido([FromBody] PedidoModel pedido)
        {
            _adicionarPedidoUseCase.Run(pedido.ToEntity());
            return CreatedAtAction(nameof(ObterPedidoPorId), new { id = pedido.Id }, pedido);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarPedido(long id, [FromBody] PedidoModel pedido)
        {
            if (id != pedido.Id)
            {
                return BadRequest();
            }

            _atualizarPedidoUseCase.Run(pedido.ToEntity());
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverPedido(long id)
        {
            _removerPedidoUseCase.Run(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult ObterPedidoPorId(long id)
        {
            var pedido = _obterPedidoPorIdUseCase.Run(id);
            if (pedido == null)
            {
                return NotFound();
            }

            return Ok(pedido);
        }
    }
}
