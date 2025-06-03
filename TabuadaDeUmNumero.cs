using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class TabuadaDeUmNumero
    {
        public static void Main(string[] args)
        {
            int i = 1, numero;
            Console.WriteLine("Tabuada de um número qualquer\n\n ");
            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt16(Console.ReadLine());
            while (i < 11)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
                i++;
            }


        }
    }
}
