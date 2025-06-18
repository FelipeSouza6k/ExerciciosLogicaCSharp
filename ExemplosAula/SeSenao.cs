using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SeSenao
    {
        public static void Main(string[] args)
        {
            int horario = 10;
            if (horario > 18 )
            {
                Console.WriteLine("Boa Noite");
            }
            else
            {
                Console.WriteLine("Bom dia");
            }
        }
    }
}
