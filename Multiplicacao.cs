using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Multiplicacao
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Digite os dois valores para a Multiplicação");
            Console.WriteLine("Digite o primeiro valor:");

            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");

            num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }
    }
}
