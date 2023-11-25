using AutoMapper;
using GestaoDeProduto.Data.Providers.MongoDb.Collections;
using GestaoDeProduto.Data.Providers.MongoDb.Interfaces;
using GestaoDeProduto.Domain.Etities;
using GestaoDeProduto.Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Data.Repositories
{
	public class CategoriaRepository : ICategoriaRepository
	{
		private readonly IMongoRepository<CategoriaCollection> _categoriaRepository;
		private readonly IMapper _mapper;

		#region - Construtores
		public CategoriaRepository(IMongoRepository<CategoriaCollection> categoriaRepository, IMapper mapper)
		{
			_categoriaRepository = categoriaRepository;
			_mapper = mapper;
		}
		#endregion

		public async Task Adicionar(Categoria categoria)
		{
			await _categoriaRepository.InsertOneAsync(_mapper.Map<CategoriaCollection>(categoria));
		}

		public Task AlterarDescricao(Categoria categoria, string novaDescricao)
		{
			throw new NotImplementedException();
		}

		public void Atualizar(Categoria categoria)
		{
			throw new NotImplementedException();
		}

		public bool Deletar(int id)
		{
			throw new NotImplementedException();
		}

		public Task Desativar(Categoria categoria)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Categoria>> ObterPorCategoria(string nomeCategoria)
		{
			throw new NotImplementedException();
		}

		public async Task<Categoria> ObterPorId(Guid id)
		{
			var buscaCategoria = _categoriaRepository.FilterBy(filter => filter.CodigoId == id);

			return _mapper.Map<Categoria>(buscaCategoria.FirstOrDefault());

		}

		public Task<Categoria> ObterPorId(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Categoria> ObterTodas()
		{
			var categoriaList = _categoriaRepository.FilterBy(filter => true);

			return _mapper.Map<IEnumerable<Categoria>>(categoriaList);
		}

		public IEnumerable<Categoria> ObterTodos()
		{
			throw new NotImplementedException();
		}

		Task ICategoriaRepository.Atualizar(Categoria categoria)
		{
			throw new NotImplementedException();
		}
	}
}
