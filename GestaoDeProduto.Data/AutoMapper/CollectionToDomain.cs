using AutoMapper;
using GestaoDeProduto.Data.Providers.MongoDb.Collections;
using GestaoDeProduto.Domain.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Data.AutoMapper
{
	public class CollectionToDomain : Profile
	{
        public CollectionToDomain()
        {

            CreateMap<ProdutoCollection, Produto>()
               .ConstructUsing(q => new Produto(q.Codigo, q.Nome, q.Descricao, q.Ativo, q.Valor, q.DataCadastro, q.Estoque, q.EstoqueMinimo));

            CreateMap<FornecedorCollection, Fornecedor>()
                .ConstructUsing(f => new Fornecedor(f.Codigo, f.RazaoSocial, f.CNPJ, f.Ativo, f.DataCadastro, f.EmailContato));

            CreateMap<CategoriaCollection, Categoria>()
                .ConstructUsing(c => new Categoria(c.Codigo, c.Descricao));

            CreateMap<UsuarioCollection, Usuario>()
                .ConstructUsing(u => new Usuario(u.Login, u.Senha, u.Ativo));
        }
    }
}
