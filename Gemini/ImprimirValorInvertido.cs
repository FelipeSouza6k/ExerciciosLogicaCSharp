using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ImprimirValorInvertido
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra para que você a veja invertida. ");
            string palavra = Console.ReadLine();
            string invertida = "";
            for(int i = palavra.Length - 1; i > -1; i--)
            {
                invertida += palavra[i];
            }
            Console.WriteLine($"{palavra} invertido é : {invertida}");
        }
    }
}
