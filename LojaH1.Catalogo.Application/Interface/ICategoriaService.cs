using LojaH1.Catalogo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//antes estava: namespace LojaH1.Catalogo.Application.Interface
namespace LojaH1.Catalogo.Application.Interface
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaViewModel>> ObterTodos();
        Task<CategoriaViewModel> ObterPorId(int id);
        Task<IEnumerable<CategoriaViewModel>> ObterPorCategoria(int codigo);
        Task Adicionar(NovaCategoriaViewModel produto);
        Task Atualizar(NovaCategoriaViewModel produto);
        bool Deletar(int id);
        Task AlterarDescricao(int id, string novaDescricao);
    }
}
