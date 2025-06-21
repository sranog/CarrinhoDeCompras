using System;
using System.Collections.Generic;
using CarrinhoDeCompras.Domain;
using CarrinhoDeCompras.Utils;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Bem vindo!\n");
            var menu = new MenuPrincipal();
            int entrada = menu.ExibirMenu();

            switch (entrada)
            {
                case 1:
                    {
                        var menuCliente = new MenuCliente();
                        int  opcaoCliente = menuCliente.ExibirMenuCliente();

                        if (opcaoCliente == 1)
                        {
                            continue;
                        }
                        else if (opcaoCliente == 7)
                        {
                            Console.WriteLine("Saindo...");
                            return;
                        }
                    }break;
                case 2:
                    { 
                        Console.WriteLine("Opção de administrador ainda não implementada.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Saindo...");
                        return;

                    }
            }
        }

    }
}