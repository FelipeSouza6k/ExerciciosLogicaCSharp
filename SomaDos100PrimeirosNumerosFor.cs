using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SomaDos100PrimeirosNumerosFor
    {
        public static void Main(string[] args)
        {
            int totalSoma = 0;
            Console.WriteLine("Soma dos 100 primeiros números");
            for (int i = 1; i <= 100; i++)
            {
                totalSoma += i;
            }
            Console.WriteLine($" Soma dos números = {totalSoma}");
        }
    }
}
