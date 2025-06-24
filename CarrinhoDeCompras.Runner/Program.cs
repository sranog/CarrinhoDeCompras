using System;
using System.Collections.Generic;
using CarrinhoDeCompras.Domain;
using CarrinhoDeCompras.Utils;

public class Program
{
    public static void Main()
    {
        // Criando instâncias de Estoque, menuAdmin e menuCliente e  carrinho de compras
        Estoque estoque = new Estoque();
        MenuAdmin menuAdmin = new MenuAdmin(estoque);
        Carrinho carrinho = new Carrinho();
        MenuCliente menuCliente = new MenuCliente(estoque,carrinho);

        while (true)
        {
            
            Console.WriteLine("Bem vindo!\n");
            var menu = new MenuPrincipal();
            int entrada = menu.ExibirMenu();

            switch (entrada)
            {
                case 1:
                    {
                        menuCliente.ExibirMenuCliente();
                        break;
                    }
                case 2:
                    {
                        
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