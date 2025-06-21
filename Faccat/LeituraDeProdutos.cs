using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class LeituraDeProdutos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Leitura de produtos e valor");
            Console.WriteLine("Digite nome do produto");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine($"Qual o preço do produto: {nomeProduto}");
            double precoProduto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Digite quantas unidades foram compradas do produto: {nomeProduto}");
            int quantidadeProduto = Convert.ToInt16(Console.ReadLine());
            double precoTotal;
            string mensagem = (quantidadeProduto <= 5)
                ? $"Desconto de 2% = R${precoTotal = precoProduto * quantidadeProduto - (precoProduto * quantidadeProduto * 0.02)}"
                : (quantidadeProduto > 5 && quantidadeProduto <= 10) ? $"Desconto de 3% = R${precoTotal = precoProduto * quantidadeProduto - (precoProduto * quantidadeProduto * 0.03)}"
                : $"Desconto de 5% = R${precoTotal = precoProduto * quantidadeProduto - (precoProduto * quantidadeProduto * 0.05)}";
            Console.WriteLine(mensagem);
            


        }
    }
}
