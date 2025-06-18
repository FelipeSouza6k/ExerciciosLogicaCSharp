using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Matriz2D
    {
        public static void Main(string[] args)
        {

            int[,] numeros = { { 1, 2, 5 }, { 3, 6, 8 } };
        //                         [linhas, colunas]
            Console.WriteLine($"{numeros[0, 2]}\n");
            Console.WriteLine($"{numeros[1, 2]}\n");
            Console.WriteLine($"{numeros[0, 1]}\n");



        }
    }
}
