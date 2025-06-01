using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Losango
    {
        public static void Main(string[] args)
        {
            double diagonalMaior, diagonalMenor;
            Console.WriteLine("Calcular área de um Losango");
            Console.WriteLine("Digite o valor da diagonal maior do losango: ");
            diagonalMaior = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da diagonal menor do losango: ");
            diagonalMenor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A área do losango = {diagonalMaior * diagonalMenor / 2}");
        }
    }
}
