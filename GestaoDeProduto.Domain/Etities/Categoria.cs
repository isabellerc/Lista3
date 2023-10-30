using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Etities
{
    public class Categoria
    {
        #region Construtores
        public Categoria(int codigo, string descricao, bool ativo)
        {
            Codigo = codigo;
            Descricao = descricao;
            Ativo = ativo;
        }

        #endregion

        #region Propriedades
        public int Codigo { get; set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }

        #endregion

        #region Comportamentos
        public void AlterarDescricao(string novaDescricao)
        {
            Descricao = novaDescricao;
        }

        #endregion
    }
}
