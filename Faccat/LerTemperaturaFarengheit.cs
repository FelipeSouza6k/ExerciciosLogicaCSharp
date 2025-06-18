using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class LerTemperaturaFarengheit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Converter Farengheit em Celsius");
            Console.WriteLine("Digite a temperatura em Farengheit: ");
            int farengheit = int.Parse(Console.ReadLine());
            Console.WriteLine($"A temperatura em Celsius é: {(farengheit - 32) * 5 / 9}°C");


        }
    }
}
