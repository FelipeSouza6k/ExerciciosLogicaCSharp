using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Hexagono
    {
        public static void Main(string[] args)
        {
            double lado, area;
            Console.WriteLine("Calcular área de um Hexágono");
            Console.WriteLine("Digite o valor do lado do Hexágono:");
            lado = Convert.ToSingle(Console.ReadLine());

            area = (3 * Math.Sqrt(3) * Math.Pow(lado,2))/2;

            Console.WriteLine($"A área deste hexágono é: {area} ");
        }
    }
}
