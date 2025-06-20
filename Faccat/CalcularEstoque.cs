using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class CalcularEstoque
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calcular quantidade em estoque de um produto");
            Console.WriteLine("Quantidade máxima em estoque: ");
            int estoqueMaximo = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade miníma em estoque:");
            int estoqueMinimo = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade em estoque:");
            int estoqueAtual = int.Parse(Console.ReadLine());

            int estoqueMedio = (estoqueMaximo + estoqueMinimo) / 2;
            string mensagem = (estoqueAtual < estoqueMedio) ? "Efetuar compra do poduto" : "Não efetuar compra do produto";
            Console.WriteLine(mensagem);
        }
    }
}
