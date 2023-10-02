using GestaoDeProduto.Domain.Etities;
using GestaoDeProduto.Domain.Interfaces;
using LojaH1.Catalogo.Application.Interface;
using LojaH1.Catalogo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaH1.Catalogo.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Adicionar(NovoProdutoViewModel novoProdutoViewModel)
        {
            _produtoRepository.Adicionar(new Produto(
                 novoProdutoViewModel.Codigo,
                 novoProdutoViewModel.Nome,
                 novoProdutoViewModel.QtdeEstoque,
                 novoProdutoViewModel.DataCadastro,
                 novoProdutoViewModel.Ativo
                ));
        }
    }
}
