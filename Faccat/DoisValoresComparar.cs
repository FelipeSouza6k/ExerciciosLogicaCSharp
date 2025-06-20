using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class DoisValoresComparar
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores ");
            Console.WriteLine("Digite o primeiro valor: ");
            float[] valor = new float[2];
            for (int i = 0; i < valor.Length; i++)
            {
                valor[i] = float.Parse(Console.ReadLine());
                if (i == 0)
                {
                    Console.WriteLine("Digite o segundo valor: ");
                }
            }
            Array.Sort(valor);
            Console.WriteLine($"Menor valor = {valor[0]} , Maior valor {valor[1]}");
            

        }
    }
}
