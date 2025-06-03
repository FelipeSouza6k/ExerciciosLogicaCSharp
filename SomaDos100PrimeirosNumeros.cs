using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SomaDos100PrimeirosNumeros
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Soma dos 100 primeiros números inteiros\n\n");
            int i = 1, totalSoma = 0;
            while(i < 101)
            {
                totalSoma += i;
                i++;
            }
            Console.WriteLine($"Total da soma dos 100 primeiros numeros inteiros\n{totalSoma}");
        }
    }
}
