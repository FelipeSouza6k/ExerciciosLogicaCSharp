using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class PotenciasDe3SemExponenciacao
    {
        public static void Main(string[] args)
        {
            ulong mult = 1;
            Console.WriteLine("Calcular potencia de 3 sem sinal de exponênciação");
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine($"3 ^ {i} = {mult}");
                mult *= 3;
            }

        }
    }
}
