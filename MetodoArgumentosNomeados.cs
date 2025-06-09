using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MetodoArgumentosNomeados
    {
        static void Crianca(string crianca1, string crianca2, string crianca3)
        {
            Console.WriteLine($"A criança mais jovem é {crianca3} ");
        }
        public static void Main(string[] args) 
        {
            Crianca(crianca3: "Arthur", crianca1: "Laura", crianca2: "Jéssica");
        }
    }
}
