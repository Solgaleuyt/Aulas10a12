using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdutoLoja loja1 = new ProdutoLoja("Doritos", 2.99, 2);

            loja1.exibirproduto();

            Console.WriteLine($"Adicione a quantidade ao estoque: ");
            string valorIntroduzido = Console.ReadLine();
            loja1.adicionarstock(int.Parse(valorIntroduzido));
            loja1.exibirproduto();

            loja1.Venderproduto(1);
            loja1.exibirproduto();
        }
    }
}
