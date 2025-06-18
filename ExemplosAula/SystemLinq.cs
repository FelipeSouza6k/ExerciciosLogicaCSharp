using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SystemLinq
    {
        public static void Main(string[] args)
        {
            int[] numeros = { 1, 5, 8, 15, 43 };
            Console.WriteLine(numeros.Min() +"\n");
            Console.WriteLine(numeros.Max() +"\n");
            Console.WriteLine(numeros.Sum() / numeros.Length + "\n\n");
        }
    }
}
