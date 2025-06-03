using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SomaNumerosPares
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatório dos numeros pares de 1 até 500");
            int i = 0, totalSoma = 0;
            do
            {
                i++;
                if (i % 2 == 0)
                {
                    totalSoma += i;
                }

            } while (i < 501);
            Console.WriteLine(totalSoma);

        }
    }
}
