using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class TabuadaDe1A10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada de 1 a 10 do número digitado");
            int numero = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
            }
        }
    }
}
