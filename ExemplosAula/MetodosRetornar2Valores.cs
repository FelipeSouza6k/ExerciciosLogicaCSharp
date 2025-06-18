using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MetodosRetornar2Valores
    {
        static int Soma(int x, int y)
        {
            return x + y;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Soma(5, 7));
        }
    }
}
