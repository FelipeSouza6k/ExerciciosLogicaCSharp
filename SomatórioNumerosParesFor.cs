using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SomatórioNumerosParesFor
    {
        public static void Main(string[] args)
        {
            int totalSoma = 0;
            Console.WriteLine("Somatório dos números pares até 500.");
            for(int i = 1; i <= 501; i++)
            {
                if (i % 2 == 0)
                {
                    totalSoma += i;
                }
            }
            Console.WriteLine($"{totalSoma}");
        }
    }
}
