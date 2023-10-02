using GestaoDeProduto.Domain.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Interfaces
{
    public interface ICategoria
    {
        public void Adicionar(Categoria novaCategoria);
        public Categoria BuscarPorId(int codigo);

        public IEnumerable<Categoria> BuscarTodos();
        public IEnumerable<Categoria> BuscarTodosAtivos();
        public IEnumerable<Categoria> BuscarTodosInativos();
    }
}
