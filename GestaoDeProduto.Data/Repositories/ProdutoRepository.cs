using AutoMapper;
using GestaoDeProduto.Data.Providers.MongoDb.Collections;
using GestaoDeProduto.Data.Providers.MongoDb.Interfaces;
using GestaoDeProduto.Domain.Etities;
using GestaoDeProduto.Domain.Interfaces;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace GestaoDeProduto.Data.Repositories
{
	public class ProdutoRepository : IProdutoRepository
	{
		private readonly IMongoRepository<ProdutoCollection> _produtoRepository;
		private readonly IMapper _mapper;

		#region - Construtores
		public ProdutoRepository(IMongoRepository<ProdutoCollection> produtoRepository, IMapper mapper)
		{
			_produtoRepository = produtoRepository;
			_mapper = mapper;
		}
		#endregion
		#region - Funções
		public async Task Adicionar(Produto produto)
		{
			await _produtoRepository.InsertOneAsync(_mapper.Map<ProdutoCollection>(produto));
		}

		public Task AlterarPreco(Produto produto, decimal valor)
		{
			throw new NotImplementedException();
		}

		public Task Ativar(Produto produto)
		{
			throw new NotImplementedException();
		}

		public void Atualizar(Produto produto)
		{
			throw new NotImplementedException();
		}

		public Task AtualizarEstoque(Produto produto, int quantidade)
		{
			throw new NotImplementedException();
		}

		public Task Deletar(Produto produto)
		{
			throw new NotImplementedException();
		}

		public async Task Desativar(Produto produto)
		{

			var buscaProduto = _produtoRepository.FilterBy(filter => filter.CodigoId == produto.CodigoId);

			if (buscaProduto == null) throw new ApplicationException("Não é possível desativar um produto que não existe");

			var produtoCollection = _mapper.Map<ProdutoCollection>(produto);

			produtoCollection.Id = buscaProduto.FirstOrDefault().Id;

			await _produtoRepository.ReplaceOneAsync(produtoCollection);
		}

		public Task<IEnumerable<Produto>> ObterPorCategoria(int codigo)
		{
			throw new NotImplementedException();
		}

		public async Task<Produto> ObterPorId(Guid id)
		{

			var buscaProduto = _produtoRepository.FilterBy(filter => filter.CodigoId == id);

			var produto = _mapper.Map<Produto>(buscaProduto.FirstOrDefault());

			return produto;
		}

		public Task<Produto> ObterPorId(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Produto>> ObterPorNome(string nomeProduto)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Produto> ObterTodos()
		{
			var produtoList = _produtoRepository.FilterBy(filter => true);

			return _mapper.Map<IEnumerable<Produto>>(produtoList);

		}

		Task IProdutoRepository.Atualizar(Produto produto)
		{
			throw new NotImplementedException();
		}
		#endregion

	}
}
