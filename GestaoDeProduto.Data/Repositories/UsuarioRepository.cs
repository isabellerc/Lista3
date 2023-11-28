using AutoMapper;
using GestaoDeProduto.Data.Providers.MongoDb.Collections;
using GestaoDeProduto.Data.Providers.MongoDb.Interfaces;
using GestaoDeProduto.Domain.Etities;
using GestaoDeProduto.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IMongoRepository<UsuarioCollection> _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioRepository(IMongoRepository<UsuarioCollection> usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<Usuario> Autenticar(string login, string senha)
        {
            var buscaUsuario = await _usuarioRepository.FindOneAsync(filtro => filtro.Login == login && filtro.Senha == senha);

            return _mapper.Map<Usuario>(buscaUsuario);
        }

        public async Task Cadastrar(Usuario novoUsuario)
        {
            await _usuarioRepository.InsertOneAsync(_mapper.Map<UsuarioCollection>(novoUsuario));
        }
    }
}
