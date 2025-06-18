using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class AlterarElementosMatriz
    {
        public static void Main(string[] args)
        {
            int[,] numeros = { { 2, 7, 8 }, { 5, 4, 6 } };
            numeros [0, 0] = 5;

            Console.WriteLine(numeros[0,0]);

        }
    }
}
