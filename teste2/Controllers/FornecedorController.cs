
using LojaH1.Catalogo.Application.Interface;
using LojaH1.Catalogo.Application.Services;
using LojaH1.Catalogo.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LOJAH1.Catalogo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
	public class FornecedorController : ControllerBase
	{
		private readonly IFornecedorService _fornecedorService;

		public FornecedorController(IFornecedorService fornecedorService)
		{
			_fornecedorService = fornecedorService;
		}

		[HttpPost]
		[Route("Adicionar")]
		public async Task<IActionResult> Post(NovoFornecedorViewModel novoFornecedorViewModel)
		{

			await _fornecedorService.Adicionar(novoFornecedorViewModel);

			return Ok("Fornecedor cadastrado com sucesso");
		}

		[HttpGet]
		[Route("ObterTodos")]
		public async Task<IActionResult> Get()
		{
			return Ok(await _fornecedorService.ObterTodos());
		}

		//Comentado ate conseguir resolver:
		//[HttpGet]
		//[Route("ObterPorCnpj/{cnpj}")]
		//public async Task<IActionResult> Get(string cnpj)
		//{
		//	//var buscaCnpj = await _fornecedorService.ObterPorCnpj(cnpj);
		//	if (buscaCnpj == null) return NotFound("Cnpj Não encontrado");
		//	return Ok(buscaCnpj);
		//}

	}
}
