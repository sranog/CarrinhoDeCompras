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
            // implementar a lógica para adicionar um produto ao carrinho
        }

        public void ExibirCarrinho()
        {
            Console.WriteLine("Exibindo carrinho de compras...\n");
            // implementar a lógica para exibir os produtos no carrinho


        }

        public void RemoverDoCarrinho()
        {
            Console.WriteLine("Removendo produto do carrinho...\n");
            // implementar a lógica para remover um produto do carrinho
            // Por exemplo, solicitar ao usuário o ID do produto a ser removido e removê-lo da lista de produtos no carrinho.
        }
    }
}
