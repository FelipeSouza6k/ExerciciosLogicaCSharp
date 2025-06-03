using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class QuadradosDosNumerosInteiros
    {
        public static void Main(string[] args)
        {
            int i = 15;
            Console.WriteLine("Apesentar quadrado dos numeros inteiros de 15 a 200");
            do
            {
                Console.WriteLine($"{i}² = {Math.Pow(i, 3)}");
                i++;
            } while (i < 201);
        }
    }
}
