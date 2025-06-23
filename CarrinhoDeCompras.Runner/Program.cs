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
                        menuCliente.ExibirMenuCliente();
                        break;
                    }
                case 2:
                    {
                        var menuAdmin = new MenuAdmin();
                        menuAdmin.ExibirMenuAdmin();
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