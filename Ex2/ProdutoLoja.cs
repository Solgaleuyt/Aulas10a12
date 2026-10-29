using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class ProdutoLoja
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public ProdutoLoja(string nome, double preco, int quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public void exibirproduto()
        {
            Console.WriteLine("Nome: " + Nome + " \n Preço: " + Preco + "€ \n Stock: " + QuantidadeEstoque);
        }

        public void adicionarstock(int add)
        {
            QuantidadeEstoque += add;
            Console.WriteLine("Estoque atualizado: " + QuantidadeEstoque);
        }

        public double Venderproduto(int quantidade)
        {
            if (quantidade <= QuantidadeEstoque)
            {
                QuantidadeEstoque -= quantidade;
                return (double)quantidade * Preco;
            }
            else
            {
                return 0.0;
            }
        }
    }
}
