using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class TrigoXadrez
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatório do número de grãos de trigo \n\n");
            ulong i = 1, trigo = 1 , totalTrigo = 1;
            do
            {
                trigo *= 2;
                Console.WriteLine(trigo);
                totalTrigo += trigo;
                i++;
            } while (i < 64);
            Console.WriteLine($"Somatório de trigos = {totalTrigo}");
        }
    }
}
