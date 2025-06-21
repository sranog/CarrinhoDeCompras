using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompras.Domain
{
    public class Estoque
    {
        private List<Produto> produtos = new List<Produto>();

        public void ListarProdutos()
        {
            Console.WriteLine("Lista de Produtos:\n");
            Console.WriteLine("ID\tNome\t\t\tPreço\tQuantidade\tCódigo\n");

            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"[{i}]\t{produtos[i].Nome}\t\t{produtos[i].Preco:F2}\t{produtos[i].Quantidade}\t{produtos[i].Codigo}");
                Console.WriteLine();
            }
        }
        public void AdicionarQuantidade(int indice, int quantidade)
        {
            if (indice >= 0 && indice < produtos.Count)
            {
                produtos[indice].Quantidade += quantidade;
                Console.WriteLine($"Quantidade atualizada: {produtos[indice].Quantidade}");
            }
            else
            {
                Console.WriteLine("Quantidade  inválida. Tente  novamente.");
            }
        }
    }
}
