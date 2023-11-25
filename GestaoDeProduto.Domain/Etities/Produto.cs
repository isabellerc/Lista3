using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GestaoDeProduto.Domain.Etities
{
	public class Produto : EntidadeBase
	{
		//entities - entidades
		#region 1 - Contrutores

		public Produto(string nome, string descricao, bool ativo, decimal valor, DateTime dataCadastro, string imagem, int quantidadeEstoque)
		{
			Nome = nome;
			Descricao = descricao;
			Ativo = ativo;
			Valor = valor;
			DataCadastro = dataCadastro;
			Imagem = imagem;
			QuantidadeEstoque = quantidadeEstoque;
		}

		public Produto(Guid codigoId, string nome, string descricao, bool ativo, decimal valor, DateTime dataCadastro, string imagem, int quantidadeEstoque)
		{
			CodigoId = codigoId;
			Nome = nome;
			Descricao = descricao;
			Ativo = ativo;
			Valor = valor;
			DataCadastro = dataCadastro;
			Imagem = imagem;
			QuantidadeEstoque = quantidadeEstoque;
		}


		#endregion

		#region 2 - Propriedades
		public string Nome { get; private set; }
		public string Descricao { get; private set; }
		public bool Ativo { get; private set; }
		public decimal Valor { get; private set; }
		public DateTime DataCadastro { get; private set; }
		public string Imagem { get; private set; }
		public int QuantidadeEstoque { get; private set; }
		public Guid CategoriaID { get; private set; }
		  public int Estoque { get; private set; }

		#endregion

		#region 3 - Comportamentos

		public void Ativar() => Ativo = true;

		public void Desativar() => Ativo = false;

		public void AlterarDescricao(string descricao) => Descricao = descricao;
		public void AlterarCategoria(Guid categoriaID) => CategoriaID = categoriaID;

		public void DebitarEstoque(int quantidade)
		{
			if (!PossuiEstoque(quantidade)) throw new Exception("Estoque insuficiente");
			QuantidadeEstoque -= quantidade;
		}

		public void ReporEstoque(int quantidade)
		{
			QuantidadeEstoque += quantidade;
		}

		public void AlterarNome(string novoNome)
		{
			Nome = novoNome;
		}

		public void AtualizarEstoque(int quantidade)
		{
			Estoque += quantidade;
		}

		public void AlterarPreco(decimal valor)
		{
			Valor = valor;
		}
		public bool PossuiEstoque(int quantidade) => QuantidadeEstoque >= quantidade;

		#endregion
	}
}
