using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Subtracao
    {
        public static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite dois valores para a Subtração");
            Console.WriteLine("Digite o primeiro valor:");

            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");

            num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"A subtração entre {num1} - {num2} é = {num1 - num2}");
        }
    }
}
