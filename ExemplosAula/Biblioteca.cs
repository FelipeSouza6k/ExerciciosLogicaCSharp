using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Biblioteca
    {
        public static void Main(string[] args)
        {
            Caderno xuxa = new Caderno();
            xuxa.cor = "Rosa";
            xuxa.paginas = 150;

            Caderno sonic = new Caderno();
            sonic.cor = "Azul";
            sonic.paginas = 250;

            Console.WriteLine($"Cor do caderno da xuxa: {xuxa.cor}\n");
            Console.WriteLine($"Paginas caderno do Sonic: {sonic.paginas}");
        }
    }
}
