using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class NumerosDivisiveisPor4
    {
        public static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Apresentar números divisiveis por 4 que estão situados entre 1 e 200\n");
            do
            {
                if (i % 4 == 0){
                    Console.WriteLine(i);
                }
                i++;

            } while (i < 201);

        }
    }
}
