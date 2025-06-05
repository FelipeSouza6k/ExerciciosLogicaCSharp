using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ApresentarNumerosImpares1e20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Apresentar valores ímpares entre 1 e 20");
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
        
