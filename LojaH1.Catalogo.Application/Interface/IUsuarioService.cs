using LojaH1.Catalogo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaH1.Catalogo.Application.Interface
{
	public interface IUsuarioService
	{
		public Task<string> Autenticar(AutenticarUsuarioViewModel autenticarUsuarioViewModel);
		public Task Cadastrar(UsuarioViewModel usuario);
	}
}
