﻿using LojaH1.Catalogo.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaH1.Catalogo.Application.Interface
{
    public interface IFornecedorService
    {
        public void Adicionar(NovoFornecedorViewModel novoFornecedorViewModel);
    }
}