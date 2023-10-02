﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Etities
{
    public class Categoria
    {

        #region Construtores
        public Categoria(int codigo, string descricao)
        {
            Codigo = codigo;
            descricao = descricao;
            
        }
        #endregion

        #region Propriedades

        public int Codigo { get; private set; }
        public string Descricao { get; private set; }

        #endregion

       
    }
}