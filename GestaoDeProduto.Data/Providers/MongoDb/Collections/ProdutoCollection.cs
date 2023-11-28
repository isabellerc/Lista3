﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Data.Providers.MongoDb.Collections
{
    [BsonCollection("Produto")]
    public class ProdutoCollection : Document
    {
        #region 2 - Propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Estoque { get; set; }
        public int EstoqueMinimo { get; set; }
        #endregion
    }
}
