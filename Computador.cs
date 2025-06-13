using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Computador
    {
        string ram = "16GB";
        string monitor = "24 Polegadas";
        string processador = "AMD Rayzen 5200";
        int memoria = 512;
        public static void Main(string[] args)
        {
            Computador tecnologia = new Computador();
            Console.WriteLine($"Memoria ram : {tecnologia.ram} ");
            Console.WriteLine($"Monitor: {tecnologia.monitor} ");
            Console.WriteLine($"Processador: {tecnologia.processador} ");
            Console.WriteLine($"Memória: {tecnologia.memoria} ");
        }
    }
}

