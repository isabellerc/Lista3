using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaH1.Catalogo.Application.ViewModel
{
    public class NovoFornecedorViewModel
    {
        public int Codigo { get; private set; }
        public string razaoSocial { get; private set; }
        public string cnpj { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }
        public string emailContato { get; private set; }
    }
}
