namespace CarrinhoDeCompras.Domain
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string Codigo { get; set; }

        public Produto(string nome, int quantidade, double preco, string codigo)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
            Codigo = codigo;
        }
    }
}

