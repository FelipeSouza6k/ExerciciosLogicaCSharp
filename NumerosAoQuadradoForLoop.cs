using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class NumerosAoQuadradoForLoop
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Elevar números do 15 a 200 ao quadrado");
            for(int i = 15; i < 201; i++)
            {
                Console.WriteLine($"{i}² = {Math.Pow(i,2)}");
            }
        }
    }
}
