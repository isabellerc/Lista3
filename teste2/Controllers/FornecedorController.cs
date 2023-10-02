
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
            public IActionResult Post(NovoFornecedorViewModel novoFornecedorViewModel)
            {
                _fornecedorService.Adicionar(novoFornecedorViewModel);
                return Ok("Registro adicionado com sucesso!");
            }
        
    }
}
