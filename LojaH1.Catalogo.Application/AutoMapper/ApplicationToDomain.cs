﻿using AutoMapper;
using GestaoDeProduto.Domain.Etities;
using LojaH1.Catalogo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaH1.Catalogo.Application.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain()
        {

            //CreateMap<ProdutoViewModel, Produto>()
            //   .ConstructUsing(q => new Produto(q.Nome, q.Descricao, q.Ativo, q.Valor, q.DataCadastro, q.Estoque));

            CreateMap<NovoProdutoViewModel, Produto>()
               .ConstructUsing(q => new Produto(q.Codigo, q.Nome, q.Descricao, q.Ativo, q.Valor, DateTime.Now, q.Estoque));

            CreateMap<NovoFornecedorViewModel, Fornecedor>()
               .ConstructUsing(q => new Fornecedor(q.Codigo, q.RazaoSocial, q.CNPJ, DateTime.Now, q.Ativo,  q.EmailContato));

            CreateMap<NovaCategoriaViewModel, Categoria>()
                .ConstructUsing(q => new Categoria(q.Codigo, q.Descricao));
        }
    }
}
