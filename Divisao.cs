using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Divisao
    {
        public static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Digite dois valores para a Divisão");
            Console.WriteLine("Digite o primeiro valor:");

            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");

            num2 = Convert.ToInt16(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Divisor não pode ser igual a 0");
            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
        }
    }
}
