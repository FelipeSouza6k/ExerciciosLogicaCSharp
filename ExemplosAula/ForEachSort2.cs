using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ForEachSort2
    {
        public static void Main(string[] args)
        {
            int[] numeros = {1, 56, 21, 67, 43 };
            Array.Sort(numeros);//Deixa os numeros em ordem crescente
            
            Array.Reverse(numeros);//Inverte a ordem que estão os números
            foreach (int valor in numeros)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
