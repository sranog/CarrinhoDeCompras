namespace CarrinhoDeCompras.Utils
{
    public static class EntradaHelper
    {
        public static int LerNumero(string mensagem)
        {
            int numero = 0;
            bool validacao;

            do
            {
                Console.Write(mensagem);
                string? entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada)) // verifico se a entrada é nula ou vazia
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    validacao = false; // se a entrada for nula ou vazia, defino validacao como false e continuo o loop
                    continue;
                }
                validacao = int.TryParse(entrada, out numero); // Agora eu tento converter a entrada para um inteiro

                if (!validacao)
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }
            } while (!validacao);

           return numero;
        }
    }
}
