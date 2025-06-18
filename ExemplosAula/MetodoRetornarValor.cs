using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MetodoRetornarValor
    {
        static int Soma(int x)
        {
            return x + 10;
        }

        public static void Main(string[] args) 
        {
            Console.WriteLine(Soma(12));
        }
    }
}
