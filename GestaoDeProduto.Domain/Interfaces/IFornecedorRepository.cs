﻿using GestaoDeProduto.Domain.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProduto.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        IEnumerable<Fornecedor> ObterTodos();
        Task<Fornecedor> ObterPorId(int id);
        Task<IEnumerable<Fornecedor>> ObterPorFornecedor(string nomeFornecedor);
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        bool Deletar(int id);
        Task AlterarEmailContato(Fornecedor fornecedor, string novoEmail);
        Task AlterarRazaoSocial(Fornecedor fornecedor, string novaRazaoSocial);
        Task Ativar(Fornecedor fornecedor);
        Task Desativar(Fornecedor fornecedor);
    }
}
