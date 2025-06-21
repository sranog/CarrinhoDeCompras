using System;
using CarrinhoDeCompras.Utils;

namespace CarrinhoDeCompras.Domain
{
    public class MenuPrincipal
    {
        public int ExibirMenu()
        {
             Console.WriteLine("----Menu Principal----");
             Console.WriteLine("Selecione uma opção:");

             Console.WriteLine("1 - Cliente");
             Console.WriteLine("2 - Administrador");
             Console.WriteLine("3 - Sair");

            int opcaoCliente = EntradaHelper.LerNumero("Digite uma opção: ");

            while (opcaoCliente < 1 || opcaoCliente > 3)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                opcaoCliente = EntradaHelper.LerNumero("Digite uma opção: ");
            }
            return opcaoCliente;
        }
    }
}
