using Domain.Interfaces.UseCases.Cliente;
using Microsoft.AspNetCore.Mvc;
using WebApi.Mappers;
using WebApi.Model.Cliente;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IAdicionarClienteUseCase _adicionarClienteUseCase;
        private readonly IAtualizarClienteUseCase _atualizarClienteUseCase;
        private readonly IObterClientePorIdUseCase _obterClientePorIdUseCase;
        private readonly IRemoverClienteUseCase _removerClienteUseCase;

        public ClienteController(IAdicionarClienteUseCase adicionarClienteUseCase, IAtualizarClienteUseCase atualizarClienteUseCase, IObterClientePorIdUseCase obterClientePorIdUseCase, IRemoverClienteUseCase removerClienteUseCase)
        {
            _adicionarClienteUseCase = adicionarClienteUseCase;
            _atualizarClienteUseCase = atualizarClienteUseCase;
            _obterClientePorIdUseCase = obterClientePorIdUseCase;
            _removerClienteUseCase = removerClienteUseCase;
        }

        [HttpPost]
        public IActionResult AdicionarCliente([FromBody] PessoaModel cliente)
        {
            var id = _adicionarClienteUseCase.Run(cliente.ToEntity());
            return CreatedAtAction(nameof(ObterClientePorId), new { id = id }, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCliente(long id, [FromBody] PessoaModel cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest();
            }

            _atualizarClienteUseCase.Run(cliente.ToEntity());
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverCliente(long id)
        {
            _removerClienteUseCase.Run(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult ObterClientePorId(long id)
        {
            var cliente = _obterClientePorIdUseCase.Run(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }
    }
}
