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
         public Estoque()
          {
                // Inicializando com alguns produtos de exemplo
                produtos.Add(new Produto("Produto A", 10, 19.99, "A001"));
                produtos.Add(new Produto("Produto B", 5, 29.99, "B002"));
                produtos.Add(new Produto("Produto C", 20, 9.99, "C003"));
        }

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
