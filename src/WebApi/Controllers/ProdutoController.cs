using Domain.Entities.Produto;
using Domain.Interfaces.UseCases.Produto;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IAdicionarProdutoUseCase _adicionarProdutoUseCase;
        private readonly IAtualizarProdutoUseCase _atualizarProdutoUseCase;
        private readonly IRemoverProdutoUseCase _removerProdutoUseCase;
        private readonly IObterProdutoPorIdUseCase _obterProdutoPorIdUseCase;
        private readonly IObterProdutoPorNomeUseCase _obterProdutoPorNomeUseCase;
        private readonly IObterTodosOsProdutosUseCase _obterTodosOsProdutosUseCase;

        public ProdutoController(IAdicionarProdutoUseCase adicionarProdutoUseCase, IAtualizarProdutoUseCase atualizarProdutoUseCase, IRemoverProdutoUseCase removerProdutoUseCase, IObterProdutoPorIdUseCase obterProdutoPorIdUseCase, IObterProdutoPorNomeUseCase obterProdutoPorNomeUseCase, IObterTodosOsProdutosUseCase obterTodosOsProdutosUseCase)
        {
            _adicionarProdutoUseCase = adicionarProdutoUseCase;
            _atualizarProdutoUseCase = atualizarProdutoUseCase;
            _removerProdutoUseCase = removerProdutoUseCase;
            _obterProdutoPorIdUseCase = obterProdutoPorIdUseCase;
            _obterProdutoPorNomeUseCase = obterProdutoPorNomeUseCase;
            _obterTodosOsProdutosUseCase = obterTodosOsProdutosUseCase;
        }

        [HttpPost]
        public IActionResult AdicionarProduto([FromBody] ProdutoEntidade produto)
        {
            _adicionarProdutoUseCase.Run(produto);
            return CreatedAtAction(nameof(ObterProdutoPorId), new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(long id, [FromBody] ProdutoEntidade produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            _atualizarProdutoUseCase.Run(produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverProduto(long id)
        {
            _removerProdutoUseCase.Run(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult ObterProdutoPorId(long id)
        {
            var produto = _obterProdutoPorIdUseCase.Run(id);
            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        [HttpGet("nome/{nome}")]
        public IActionResult ObterProdutoPorNome(string nome)
        {
            var produto = _obterProdutoPorNomeUseCase.Run(nome);
            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        [HttpGet]
        public IActionResult ObterTodosOsProdutos()
        {
            var produtos = _obterTodosOsProdutosUseCase.Run();
            return Ok(produtos);
        }

    }
}