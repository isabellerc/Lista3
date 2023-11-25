using LojaH1.Catalogo.Application.Interface;
using LojaH1.Catalogo.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace LojaH1.Catalogo.API.Controllers
//namespace GestaoDeProduto.Catalogo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
	public class CategoriaController : ControllerBase
	{
		private readonly ICategoriaService _categoriaService;
		public CategoriaController(ICategoriaService categoriaService)
		{
			_categoriaService = categoriaService;
		}

		[HttpPost]
		[Route("Adicionar")]
		public async Task<IActionResult> Post(NovaCategoriaViewModel categoriaViewModel)
		{
			await _categoriaService.Adicionar(categoriaViewModel);

			return Ok();
		}



		[HttpGet]
		[Route("ObterTodos")]
		public IActionResult Get()
		{
			return Ok(_categoriaService.ObterTodos());
		}
	}
}
        
