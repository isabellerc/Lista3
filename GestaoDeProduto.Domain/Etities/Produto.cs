using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Etities
{
    //entities - entidades
    public class Produto
    {

        #region Construtores
        public Produto(int codigo, string nome, int qtdeEstoque, DateTime dataCadastro, bool ativo)
        {
            Codigo = codigo;
            Nome = nome;
            QtdeEstoque = qtdeEstoque;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }
        #endregion

        #region Propriedades

        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public int QtdeEstoque { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }

        #endregion

        #region Funções

        public void AdicionarEstoque(int qtde)
        {
            QtdeEstoque += qtde;
        }

        public void RetirarEstoque(int qtde) => QtdeEstoque -= qtde;
        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        #endregion
    }
}
