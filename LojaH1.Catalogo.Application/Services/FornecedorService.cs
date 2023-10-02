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
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public void Adicionar(NovoFornecedorViewModel novoFornecedorViewModel)
        {
            _fornecedorRepository.Adicionar(new Fornecedor(
                 novoFornecedorViewModel.Codigo,
                 novoFornecedorViewModel.razaoSocial,
                 novoFornecedorViewModel.cnpj,
                 novoFornecedorViewModel.DataCadastro,
                 novoFornecedorViewModel.Ativo,
                 novoFornecedorViewModel.emailContato
                 
                ));
        }
    }
}
