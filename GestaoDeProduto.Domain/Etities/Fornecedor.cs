using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Etities
{
    public class Fornecedor
    {

        #region Construtores
        public Fornecedor(int codigo, string razaoSocial, string cnpj, DateTime dataCadastro, bool ativo, string emailContato)
        {
            Codigo = codigo;
            razaoSocial = razaoSocial;
            cnpj = cnpj;
            DataCadastro = dataCadastro;
            Ativo = ativo;
            emailContato = emailContato;
        }
        #endregion

        #region Propriedades

        public int Codigo { get; private set; }
        public string razaoSocial { get; private set; }
        public string cnpj { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }
        public string emailContato { get; private set; }

        #endregion

        
    }
}
