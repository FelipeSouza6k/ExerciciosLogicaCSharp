using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ApresentarNumerosDivisiveisPor4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Apresentar todos os números divisíveis por 4 entre 1 e 200");
            for (int i = 1; i < 201; i++)
            {
                if (i % 4 == 0) { 
                Console.WriteLine(i);
                }
            }
        }
    }
}
