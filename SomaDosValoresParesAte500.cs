using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SomaDosValoresParesAte500
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Soma dos números pares até 1 até 500\n\n\n");
            int i = 2 ,totalSoma = 0;
            while (i < 501)
            {
                totalSoma += i;
                i += 2;
            }
            Console.WriteLine($"A soma dos números pares situados até 500 é:\n\n{totalSoma}");
        }
    }
}
