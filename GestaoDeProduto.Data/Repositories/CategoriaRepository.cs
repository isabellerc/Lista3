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
        #region - Construtor
        private readonly string _categoriaCaminhoArquivo;

        public CategoriaRepository()
        {
            _categoriaCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(),
                "FileJsonData", "categoria.json");
        }

        #endregion

        #region - Funções do repositorio
        public void Adicionar(Categoria novaCategoria)
        {
            List<Categoria> categorias = new List<Categoria>();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            categorias.Add(novaCategoria);
            EscreverCategoriasNoArquivo(categorias);
        }

        public Categoria BuscarPorId(int codigo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> BuscarTodosAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> BuscarTodosInativos()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Funções do arquivo
        private List<Categoria> LerCategoriasDoArquivo()
        {
            if (!System.IO.File.Exists(_categoriaCaminhoArquivo))
            {
                return new List<Categoria>();
            }

            string json = System.IO.File.ReadAllText(_categoriaCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Categoria>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<Categoria> categorias = LerCategoriasDoArquivo();
            if (categorias.Any())
            {
                return categorias.Max(p => p.Codigo) + 1;
            }
            else
            {
                return 1;
            }
        }

        private void EscreverCategoriasNoArquivo(List<Categoria> categorias)
        {
            string json = JsonConvert.SerializeObject(categorias);
            System.IO.File.WriteAllText(_categoriaCaminhoArquivo, json);
        }

        #endregion
    }
}
