using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Circulo
    {
        public static void Main(string[] args)
        {
            double raio;
            const float pi = 3.14f;
            Console.WriteLine("Calcular área de um Circulo");
            Console.WriteLine("Digite o raio do círculo:");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A área do círculo é: {pi * (Math.Pow(raio, 2))}");
        }
    }
}
