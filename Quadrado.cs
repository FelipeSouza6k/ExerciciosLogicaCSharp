using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Quadrado
    {
        public static void Main(string[]args)
        {
            double lado;
            Console.WriteLine("Calcular área de um Quadrado");
            Console.WriteLine("Digite o valor do lado do quadrado: ");

            lado = Convert.ToDouble(Console.ReadLine());

            if (lado <= 0)
            {
                Console.WriteLine("O valor do lado deve ser maior que zero.");
                return;
            }
            else
            {
                Console.WriteLine($"A área do quadrado = {Math.Pow(lado, 2)}");
            }
        }
    }
}
