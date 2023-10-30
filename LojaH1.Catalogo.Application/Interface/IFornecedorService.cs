using LojaH1.Catalogo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaH1.Catalogo.Application.Interface
{
    public interface IFornecedorService
    {
        Task<IEnumerable<FornecedorViewModel>> ObterTodos();
    Task<FornecedorViewModel> ObterPorId(int id);
    Task<IEnumerable<FornecedorViewModel>> ObterPorFornecedor(string nomeFornecedor);
    Task Adicionar(NovoFornecedorViewModel novoFornecedor);
    Task Atualizar(NovoFornecedorViewModel novoFornecedor);
    bool Deletar(int id);
    Task AlterarEmailContato(int id, string novoEmail);
    Task AlterarRazaoSocial(int id, string novaRazaoSocial);
    Task Ativar(int id);
    Task Desativar(int id);
}
}
