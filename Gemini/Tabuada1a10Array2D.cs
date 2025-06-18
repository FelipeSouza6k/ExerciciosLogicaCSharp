using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Tabuada1a10Array2D
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada de 1 a 10");
            int i, j;
            int[,] multiplicacao = new int[10, 10];

            for (i = 0; i < multiplicacao.GetLength(0) ; i++) 
            {
                for (j = 0; j < multiplicacao.GetLength(1); j++)
                {
                    multiplicacao[i, j] = (i + 1) * (j + 1);
                    Console.Write($"{multiplicacao[i, j] }\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
