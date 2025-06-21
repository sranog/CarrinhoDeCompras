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
        public int ExibirMenuCliente()
        {

            Console.WriteLine("----Menu Cliente----");
            Console.WriteLine("Selecione uma opção:");

            Console.WriteLine("1 - Voltar ao menu principal");
            Console.WriteLine("2 - Ver produtos disponíveis");
            Console.WriteLine("3 - Adicionar produto ao carrinho");
            Console.WriteLine("4 - Ver carrinho de compras");
            Console.WriteLine("5 - Remover  produto do carrinho");
            Console.WriteLine("6 - Finalizar compra");
            Console.WriteLine("7  - Sair");

            int opcaoCliente = EntradaHelper.LerNumero("Digite uma opção: ");

            while (opcaoCliente < 1 || opcaoCliente > 7)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                opcaoCliente = EntradaHelper.LerNumero("Digite uma opção: ");
            }
            switch (opcaoCliente)
            {

                case 2:
                    Console.WriteLine("Exibindo produtos disponíveis...");
                    
                    break;
                case 3:
                    Console.WriteLine("Adicionando produto ao carrinho...");
                   
                    break;
                case 4:
                    Console.WriteLine("Exibindo carrinho de compras...");
                   
                    break;
                case 5:
                    Console.WriteLine("Removendo produto do carrinho...");
                    
                    break;
                case 6:
                    Console.WriteLine("Finalizando compra...");
                   
                    break;

            }

            return opcaoCliente;

        }
    }
}

  

  