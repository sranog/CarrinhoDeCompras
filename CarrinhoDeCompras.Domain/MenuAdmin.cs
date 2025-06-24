using CarrinhoDeCompras.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompras.Domain
{
    public class MenuAdmin
    {
        private Estoque estoque;
        public MenuAdmin(Estoque estoqueExistente)
        {
            estoque = estoqueExistente;
        }
        public int ExibirMenuAdmin()
        {
            while (true)
            {
                Console.WriteLine("----Menu Administrador----\n");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Voltar ao menu principal");
                Console.WriteLine("2 - Listar todos os produtos");
                Console.WriteLine("3 - Adicionar quantidade ao produto");
                Console.WriteLine("4 - Remover produto");
                Console.WriteLine("5 - Editar produto");
                Console.WriteLine("6 - Cadastrar produto");
                Console.WriteLine("7 - Sair");

                int opcaoAdmin = EntradaHelper.LerNumero("Digite uma opção: ");

                switch (opcaoAdmin)
                {
                    case 1:
                        {
                            Console.WriteLine("Voltando ao menu principal...");
                            return opcaoAdmin;
                        }
                    case 2:
                        {
                            Console.WriteLine("Listando todos os produtos...");

                            estoque.ListarProdutosAdm();
                            break;
                        }
                    case 3:
                        {                            
                            Console.WriteLine("Adicionando produto...");

                                int indice = EntradaHelper.LerNumero("Digite o índice do produto: ");
                                int quantidade = EntradaHelper.LerNumero("Digite a quantidade a ser adicionada: ");
                                estoque.AdicionarQuantidade(indice, quantidade);

                            break;
                        }

                }



            }
        }
    }
}
