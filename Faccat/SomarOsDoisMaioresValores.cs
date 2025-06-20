using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class SomarOsDoisMaioresValores
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somar os dois maiores valores digitados");
            int[] valor = new int[3];
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine($"Digite um valor: ");
                valor[i] = int.Parse(Console.ReadLine());
            }
           Array.Sort(valor);
           int maior = valor[valor.Length - 1];
           int maior2 = valor[valor.Length - 2];
            Console.WriteLine($"Os dois maiores valores são {maior} e {maior2}\nA soma deles são: {maior + maior2}");
        }
    }
}
