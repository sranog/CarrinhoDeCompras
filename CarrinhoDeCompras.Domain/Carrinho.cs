using CarrinhoDeCompras.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//  criando  os metodos do carrinho de compras. Futuramente serão separadas em arquivos diferentes para melhor organização e manutenção do código. 

namespace CarrinhoDeCompras.Domain
{
    public class Carrinho
    {
        private List<Produto> produtosCarrinho = new List<Produto>();

        public void AdicionarAoCarrinho()
        {
            Console.WriteLine("Adicionando produto ao carrinho...\n");

            for (int i = 0; i < produtosCarrinho.Count; i++)
            {
                Console.WriteLine($"[{i}]\t{produtosCarrinho[i].Nome}\t\t{produtosCarrinho[i].Preco:F2}\t{produtosCarrinho[i].Quantidade}\t{produtosCarrinho[i].Codigo}");
            }

            int indice;
            while (true)
            {
                Console.WriteLine("\nDigite o número do produto para adicionar:");
                int entrada = EntradaHelper.LerNumero("Digite uma opção:  ");

                if (entrada  >= 0 && entrada < produtosCarrinho.Count)
                {
                    indice = entrada;
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um número válido");
                }
            }

        }

        public void ExibirCarrinho()
        {
            Console.WriteLine("Exibindo carrinho de compras...\n");
         

        }
       
        public void RemoverDoCarrinho()
        {
            Console.WriteLine("Removendo produto do carrinho...\n");
            // implementar a lógica para remover um produto do carrinho
            // Por exemplo, solicitar ao usuário o ID do produto a ser removido e removê-lo da lista de produtos no carrinho.
        }
    }
}
