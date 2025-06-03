using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Sucessor
    {
        public static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Digite um valor para descubrir o Sucessor");

            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"O sucessor do numero {num1} é {num1 + 1}");

        }
    }
}
