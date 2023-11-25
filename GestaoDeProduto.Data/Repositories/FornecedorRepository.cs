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
	public class FornecedorRepository : IFornecedorRepository
	{

		private readonly IMongoRepository<FornecedorCollection> _fornecedorRepository;
		private readonly IMapper _mapper;

		public FornecedorRepository(IMongoRepository<FornecedorCollection> fornecedorRepository,
			IMapper mapper
			)
		{
			_fornecedorRepository = fornecedorRepository;
			_mapper = mapper;
		}

		public async Task Adicionar(Fornecedor fornecedor)
		{
			var novoFornecedorCollection = _mapper.Map<FornecedorCollection>(fornecedor);
			await _fornecedorRepository.InsertOneAsync(novoFornecedorCollection);
		}

		public Task AlterarEmailContato(Fornecedor fornecedor, string novoEmail)
		{
			throw new NotImplementedException();
		}

		public Task AlterarRazaoSocial(Fornecedor fornecedor, string novaRazaoSocial)
		{
			throw new NotImplementedException();
		}

		public Task Ativar(Fornecedor fornecedor)
		{
			throw new NotImplementedException();
		}

		public Task Atualizar(Fornecedor fornecedor)
		{
			throw new NotImplementedException();
		}

		public bool Deletar(int id)
		{
			throw new NotImplementedException();
		}

		public Task Desativar(Fornecedor fornecedor)
		{
			throw new NotImplementedException();
		}

		public async Task<Fornecedor> ObterPorCnpj(string cnpj)
		{
			//var resultadoBuscaCnpj =  _fornecedorRepository.FilterBy(filtro => filtro.Cnpj == cnpj)
			//	.FirstOrDefault();
			//return _mapper.Map<Fornecedor>(resultadoBuscaCnpj);

			var resultadoBuscaCnpj2 = _fornecedorRepository.FindOneAsync(filtro => filtro.Cnpj == cnpj);
			return _mapper.Map<Fornecedor>(resultadoBuscaCnpj2);

		}

		public Task<IEnumerable<Fornecedor>> ObterPorFornecedor(string nomeFornecedor)
		{
			throw new NotImplementedException();
		}

		public Task<Fornecedor> ObterPorId(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Fornecedor>> ObterTodos()
		{
			var listaDeFornecedores = _fornecedorRepository.FilterBy(filtro => true);

			return _mapper.Map<IEnumerable<Fornecedor>>(listaDeFornecedores);

		}

		public Task Remover(Fornecedor fornecedor)
		{
			throw new NotImplementedException();
		}

		IEnumerable<Fornecedor> IFornecedorRepository.ObterTodos()
		{
			throw new NotImplementedException();
		}
	}
}
