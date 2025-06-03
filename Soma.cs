using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Soma
    {
        public static void Main(string[]args)
        {
            int num1, num2;
            Console.WriteLine("Digite dois valores para a soma");
            Console.WriteLine("Digite o primeiro valor:");

            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");

            num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("O valor da soma é:");
            Console.WriteLine(num1 + num2);
        }
    }
}
