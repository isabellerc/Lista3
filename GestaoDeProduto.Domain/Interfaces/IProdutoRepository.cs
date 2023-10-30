using GestaoDeProduto.Domain.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Interfaces
//interfaces - onde colocamos as ações que a entidade faz (entities)
{ //aqui vamos implementar o que fazer e não como fazer  - exemplos abaixo do que eu posso fazer com um produto -> adc, atualizar
  //ou seja aqui é só a assinatura do que o método faz e não executa
    public interface IProdutoRepository
    {
        IEnumerable<Produto> ObterTodos();
        Task<Produto> ObterPorId(int id);
        Task<IEnumerable<Produto>> ObterPorNome(string nomeProduto);
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Deletar(Produto produto);
        Task Ativar(Produto produto);
        Task Desativar(Produto produto);
        Task AlterarPreco(Produto produto, decimal valor);
        Task AtualizarEstoque(Produto produto, int quantidade);
    }
}
