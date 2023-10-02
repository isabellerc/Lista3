using GestaoDeProduto.Data.Repositories;
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
    public class CategoriaService : ICategoriaService
    {
        private readonly CategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public void Adicionar(NovaCategoriaViewModel novaCategoriaViewModel)
        {
            _categoriaRepository.Adicionar(new Categoria(
                 novaCategoriaViewModel.codigo,
                 novaCategoriaViewModel.descricao
                ));
        }

        void ICategoriaService.Adicionar(NovaCategoriaViewModel novaCategoriaViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
