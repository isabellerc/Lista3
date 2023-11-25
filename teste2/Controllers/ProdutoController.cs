using LojaH1.Catalogo.Application.Interface;
using LojaH1.Catalogo.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LOJAH1.Catalogo.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
	public class ProdutoController : ControllerBase
	{
		private readonly IProdutoService _produtoService;
		public ProdutoController(IProdutoService produtoService)
		{
			_produtoService = produtoService;
		}

		[HttpPost]
		[Route("Adicionar")]
		public IActionResult Post(NovoProdutoViewModel novoProdutoViewModel)
		{
			_produtoService.Adicionar(novoProdutoViewModel);

			return Ok("Registro adicionado com sucesso!");
		}

		[HttpPut]
		[Route("Desativar/{id}")]
		public async Task<IActionResult> Put(Guid id)
		{
			await _produtoService.Desativar(id);

			return Ok("Produto desativado com sucesso");
		}

		[HttpGet]
		[Route("ObterTodos")]
		public IActionResult Get()
		{
			return Ok(_produtoService.ObterTodos());
		}
	}
}

