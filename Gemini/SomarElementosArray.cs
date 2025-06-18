using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SomarElementosArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somar todos os elementos de um array");
            double[] numeros = new double[5];
            Console.WriteLine("Digite o primeiro valor ");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o próximo valor: ");
            }
            Console.WriteLine($"\nA soma de todos os valores digitados é : {numeros.Sum()}");
        }
    }
}
