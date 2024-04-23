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

        //propriedades
        public MarcaEletronico Marca { get => marca; }
        public string Modelo { get => modelo; }

        public Eletronico(string nome, string codigo, int quantidadeEstoque, double precoCompra, MarcaEletronico marca, string modelo)
            : base(nome, codigo, quantidadeEstoque, precoCompra)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Marca: {this.marca}\n" +
                   $"Modelo: {this.modelo}\n";
        }
    }
}
