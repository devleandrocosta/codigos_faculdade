using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVendeTudo
{
    internal class Alimento : Produto
    {
        //atributos
        private DateTime dataValidade { get; }
        private const double PERCENTUAL_LUCRO = 30;

        public Alimento(string nome, string codigo, int quantidadeEstoque, double precoCompra, DateTime dataValidade)
            : base(nome, codigo, quantidadeEstoque, precoCompra)
        {
            this.dataValidade = dataValidade;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Data de Validade: {this.dataValidade}\n";
        }

        public override double obterPrecoVenda()
        {
            return precoCompra * IndiceComercializacao(PERCENTUAL_LUCRO);
        }
    }
}
