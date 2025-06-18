using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Triangulo
    {
        public static void Main(string[] args)
        {
            double bass, altura;
            Console.WriteLine("Cálculo da área do Triângulo");
            Console.WriteLine("Digite a base do triângulo:");
            bass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura do triângulo:");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A área do triângulo é: {bass * altura/2}");

        }
    }
}
