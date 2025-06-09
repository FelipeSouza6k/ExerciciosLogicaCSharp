using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class CustoCarro
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calcular preço do carro para um consumidor final\n ");
            double impostos = 0.45 + 0.28 + 1;

            Console.WriteLine("Digiteo preço de custo de fábrica do carro");
            double precoFabrica = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O preço final deste carro para o consumidor é: {precoFabrica * impostos}");
        }
    }
}
