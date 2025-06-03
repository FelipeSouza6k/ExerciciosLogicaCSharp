using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Trapezio
    {
        public static void Main(string[] args)
        {
            double baseMaior, baseMenor, altura, area;
            Console.WriteLine("Calcular área de um Trapézio");
            Console.WriteLine("Digite o valor da base maior do Trapézio:");

            baseMaior = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da base menor do Trapézio:");

            baseMenor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do Trapézio:"); 

            altura = Convert.ToDouble(Console.ReadLine());
            area = ((baseMaior + baseMenor) * altura / 2);

            Console.WriteLine($"A área do trapézio é: {area}"); 
        }   
    }
}
