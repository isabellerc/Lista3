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
    internal class FornecedorRepository : IFornecedorRepository
    {
        #region - Construtor
        private readonly string _fornecedorCaminhoArquivo;

        public FornecedorRepository()
        {
            _fornecedorCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(),
                "FileJsonData", "fornecedor.json");
        }

        #endregion

        #region - Funções do repositorio
        public void Adicionar(Fornecedor novoFornecedor)
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            fornecedores.Add(novoFornecedor);
            EscreverProdutosNoArquivo(fornecedores);
        }

        public Fornecedor BuscarPorId(int codigo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fornecedor> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fornecedor> BuscarTodosAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fornecedor> BuscarTodosInativos()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Funções do arquivo
        private List<Fornecedor> LerFornecedoresDoArquivo()
        {
            if (!System.IO.File.Exists(_fornecedorCaminhoArquivo))
            {
                return new List<Fornecedor>();
            }

            string json = System.IO.File.ReadAllText(_fornecedorCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Fornecedor>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<Fornecedor> fornecedores = LerFornecedoresDoArquivo();
            if (fornecedores.Any())
            {
                return fornecedores.Max(p => p.Codigo) + 1;
            }
            else
            {
                return 1;
            }
        }

        private void EscreverFornecedoresNoArquivo(List<Fornecedor> fornecedores)
        {
            string json = JsonConvert.SerializeObject(fornecedores);
            System.IO.File.WriteAllText(_fornecedorCaminhoArquivo, json);
        }

        #endregion
    }
}
