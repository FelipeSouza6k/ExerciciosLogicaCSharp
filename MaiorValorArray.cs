using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MaiorValorArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maior valor do array\n");
            Console.WriteLine("Digite o primeiro valor");
            double[] numeros = new double[3];
            int i = 0;
            foreach (double numero in numeros)
            {
                numeros[i] = Convert.ToDouble(Console.ReadLine());
                i++;
                Console.WriteLine($"Digite o próximo valor: ");
            }
            Console.WriteLine($"{numeros.Max()}");
        }
    }
}