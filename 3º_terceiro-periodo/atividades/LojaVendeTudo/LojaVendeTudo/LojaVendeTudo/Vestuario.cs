using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVendeTudo
{
    internal class Vestuario : Produto
    {
        //atributos
        private TipoVestuario tipo;
        private string tamanho;
        private string cor;

        //propriedades
        public string Tamanho { get => tamanho; }
        public string Cor { get => cor; }

        public Vestuario(string nome, string codigo, int quantidadeEstoque, double precoCompra, string tamanho, string cor, TipoVestuario tipo) :
            base(nome, codigo, quantidadeEstoque, precoCompra)
        {
            this.tamanho = tamanho;
            this.cor = cor;
            this.tipo = tipo;
        }

        public Vestuario(string nome, string codigo, int quantidadeEstoque, double precoCompra, string tamanho, string cor) :
            base(nome, codigo, quantidadeEstoque, precoCompra)
        {
            this.tamanho = tamanho;
            this.cor = cor;
            this.tipo = TipoVestuario.POPULAR;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Tamanho: {this.tamanho}\n" +
                   $"Cor: {this.cor}\n" +
                   $"Tipo: {this.tipo}\n";
        }
    }
}
