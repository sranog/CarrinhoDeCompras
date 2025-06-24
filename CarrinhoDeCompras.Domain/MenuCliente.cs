using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrinhoDeCompras.Utils;

namespace CarrinhoDeCompras.Domain
{
    public class MenuCliente
    {
        private Estoque estoque;
        private Carrinho carrinho;
        public MenuCliente(Estoque estoqueExistente, Carrinho carrinhoExistente)
        {
            estoque = estoqueExistente;
            carrinho = carrinhoExistente;
        }
        public int ExibirMenuCliente()
        {
            while (true)
            {
            Console.WriteLine("----Menu Cliente----\n");
            Console.WriteLine("Selecione uma opção:");

            Console.WriteLine("1 - Voltar ao menu principal");
            Console.WriteLine("2 - Ver produtos disponíveis");
            Console.WriteLine("3 - Adicionar produto ao carrinho");
            Console.WriteLine("4 - Ver carrinho de compras");
            Console.WriteLine("5 - Remover  produto do carrinho");
            Console.WriteLine("6 - Finalizar compra");
            Console.WriteLine("7  - Sair");

            int opcaoCliente = EntradaHelper.LerNumero("Digite uma opção: ");

             if (opcaoCliente < 1 || opcaoCliente > 7)
                 {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue; 
                 }

                    switch (opcaoCliente)
                    {
                        case 1:
                            Console.WriteLine("Voltando ao menu principal...");
                            return opcaoCliente;
                       
                        case 2:
                            Console.WriteLine("Exibindo produtos disponíveis...");
                            estoque.ListarProdutosCliente();
                            break;
                        case 3:
                            Console.WriteLine("Adicionando produto ao carrinho..."); 
                            carrinho.AdicionarAoCarrinho();
                        break;

                        case 4:
                            Console.WriteLine("Exibindo carrinho de compras...");
                            carrinho.ExibirCarrinho();
                        break;

                        case 5:
                            Console.WriteLine("Removendo produto do carrinho...");
                            carrinho.RemoverDoCarrinho();
                        break;

                        case 6:
                            Console.WriteLine("Finalizando compra...");
                            break;
                        case 7:
                            Console.WriteLine("Saindo do sistema...");
                            Environment.Exit(0);
                            break;

                }
            }

        }
    }
}

  

  