using CarrinhoDeCompras.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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
                Console.WriteLine("4 - Remover quantidade do produto");
                Console.WriteLine("5 - Remover produto");
                Console.WriteLine("6 - Alterar o nome do produto");
                Console.WriteLine("7 - Alterar preço do produto");
                Console.WriteLine("8 - Cadastrar produto");
                Console.WriteLine("9 - Sair");
                /* Console.WriteLine(" - Editar produto");*/

                int opcaoAdmin = EntradaHelper.LerNumero("Digite uma opção: ");

                if (opcaoAdmin < 1 || opcaoAdmin > 9)
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }
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
                            // futuramente irei criar outro  metodo paraa que os metodos de entradas fiquem dentro da classe estoque
                            estoque.ListarProdutosAdm();

                            int indice = EntradaHelper.LerNumero("Digite o índice do produto: ");
                            int quantidade = EntradaHelper.LerNumero("Digite a quantidade a ser adicionada: ");
                            estoque.AdicionarQuantidade(indice, quantidade);

                            break;
                        }
                    case 4:
                        {
                            // futuramente irei criar outro  metodo paraa que os metodos de entradas fiquem dentro da classe estoque
                            estoque.ListarProdutosAdm();

                            int indice = EntradaHelper.LerNumero("Digite o índice do produto: ");
                            int quantidade = EntradaHelper.LerNumero("Digite a quantidade a ser removida: ");
                            estoque.RemoverQuantidade(indice, quantidade);

                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Cadastrando produto...");
                            estoque.CadastrarProduto();
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Saindo do sistema...");
                            Environment.Exit(0);
                            break;
                        }

                }



            }
        }
    }
}
