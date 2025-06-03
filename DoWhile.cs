using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class DoWhile
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Utilizando Do While");
            int i = 1;
            do
            {
                i++;
                Console.WriteLine(i);
                
            } while (i < 5);
        }
    }
}
