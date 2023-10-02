using LojaH1.Catalogo.Application.Interface;
using LojaH1.Catalogo.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace LOJAH1.Catalogo.API.Controllers
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
                    public IActionResult Post(NovaCategoriaViewModel novaCategoriaViewModel)
                    {
                        _categoriaService.Adicionar(novaCategoriaViewModel);
                        return Ok("Registro adicionado com sucesso!");
                    }
                }
            }
        
