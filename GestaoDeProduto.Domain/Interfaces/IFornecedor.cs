using GestaoDeProduto.Domain.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Interfaces
{
    public class IFornecedor
    {
        public void Adicionar(Fornecedor novoFornecedor);
        public Fornecedor BuscarPorId(int codigo);

        public IEnumerable<Fornecedor> BuscarTodos();
        public IEnumerable<Fornecedor> BuscarTodosAtivos();
        public IEnumerable<Fornecedor> BuscarTodosInativos();
    }
}
