using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class Ler3ValoresMaiorDeles
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores para ver qual o maior deles");
            int[] valor = new int[3];
            for (int i = 0; i < valor.Length; i++)
            {
                valor[i] = int.Parse(Console.ReadLine());
            }
            int maior = valor.Max();
            Console.WriteLine($"O maior valor é: {maior}");
        }
    }
}
