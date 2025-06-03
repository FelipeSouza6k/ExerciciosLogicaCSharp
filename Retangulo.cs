using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Retangulo
    {
        public static void Main(string[] args)
        {
            int altura, bass;
            Console.WriteLine("Calcular área de um retangulo");
            Console.WriteLine("Digite a altura do retângulo");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a largura do retângulo");
            bass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A área do triângulo é: {bass * altura}");


            
        }
    }
}
