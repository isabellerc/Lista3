using AutoMapper;
using GestaoDeProduto.Domain.Interfaces;
//using H1Store.Catalogo.Application.Interfaces;
//using H1Store.Catalogo.Application.ViewModels;
//using H1Store.Catalogo.Infra.Autenticacao;
using LojaH1.Catalogo.Application.Interface;
using LojaH1.Catalogo.Application.ViewModel;
using LojaH1.Catalogo.Infra.Autenticacao;
using Microsoft.AspNetCore.Mvc;

namespace H1Store.Catalogo.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private IMapper _mapper;

        public UsuarioController(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        //[HttpPost]
        //[Route("login")]
        //public async Task<ActionResult<dynamic>> Autenticar([FromBody] UsuarioViewModel usuarioViewModel)
        //{
        //    var buscarUsuario = _usuarioRepository.Autenticar(_mapper.Map<Usuario>(usuarioViewModel));

        //    if (buscarUsuario == null)
        //    {
        //        return NotFound(new { message = "Usuário não existe e/ou senha inválida" });
        //    }

        //    var token = TokenService.GenerateToken(buscarUsuario);

        //    buscarUsuario = "";

        //    return new
        //    {
        //        usuario = buscarUsuario,
        //        token = token
        //    };
        //}
    }
}
