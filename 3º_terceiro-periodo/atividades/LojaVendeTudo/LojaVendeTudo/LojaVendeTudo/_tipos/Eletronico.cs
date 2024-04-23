using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVendeTudo
{
    internal class Eletronico : Produto
    {
        private MarcaEletronico marca;
        private string modelo;
        private const double PERCENTUAL_LUCRO_APPLE = 20;
        private const double PERCENTUAL_LUCRO_ELETRONICO = 10;

        //propriedades
        public MarcaEletronico Marca { get => marca; }
        public string Modelo { get => modelo; }

        public Eletronico(string nome, string codigo, int quantidadeEstoque, double precoCompra, MarcaEletronico marca, string modelo)
            : base(nome, codigo, quantidadeEstoque, precoCompra)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Marca: {this.marca}\n" +
                   $"Modelo: {this.modelo}\n";
        }

        public override double obterPrecoVenda()
        {
            if(marca == MarcaEletronico.APPLE){
                return precoCompra * IndiceComercializacao(PERCENTUAL_LUCRO_APPLE);
            }
            return precoCompra * IndiceComercializacao(PERCENTUAL_LUCRO_ELETRONICO);
        }
    }
}
