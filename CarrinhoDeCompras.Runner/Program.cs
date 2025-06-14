using System;
using System.Collections.Generic;
using CarrinhoDeCompras.Domain;

public class Program
{
    public static void Main()
    {
        List<Produto> produtos = new List<Produto>();
        produtos.Add(new Produto("Biscoito de Morango", 10, 2.50, "BISC6764"));
        produtos.Add(new Produto("Suco de Laranja 1L", 20, 4.99, "SUCO1010"));
        produtos.Add(new Produto("Leite Integral 1L", 15, 5.49, "LEIT3344"));
        produtos.Add(new Produto("Arroz Tipo 1 - 5kg", 7, 22.90, "ARRO5587"));
        produtos.Add(new Produto("Detergente Neutro 500ml", 30, 1.99, "DETG9042"));
        produtos.Add(new Produto("Shampoo Anticaspa 300ml", 12, 12.75, "SHMP2211"));

        Console.WriteLine("Lista de Produtos:\n");
        Console.WriteLine("ID\tNome\t\t\tPreço\tQuantidade\tCódigo\n");

        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine($"[{i}]\t{produtos[i].Nome}\t\t{produtos[i].Preco:F2}\t{produtos[i].Quantidade}\t{produtos[i].Codigo}");
            Console.WriteLine();
        }

        int indice;
        while (true)
        {
            Console.WriteLine("Digite o ID do produto que deseja adicionar: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out indice) && indice >= 0 && indice < produtos.Count)
            {
                Console.WriteLine("Você selecionou o  produto: " + produtos[indice].Nome);
                Console.WriteLine("Quantidade a adicionar: ");
                string quantidadeEntrada = Console.ReadLine();
                if (int.TryParse(quantidadeEntrada, out int quantidade) && quantidade > 0)
                {
                    produtos[indice].Quantidade += quantidade;
                    Console.WriteLine($"Quantidade atualizada: {produtos[indice].Quantidade}");
                }
                else
                {
                    Console.WriteLine("Quantiade  inválida. Tente  novamente.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido. Tente novamente.");
            }
        }
    }
}