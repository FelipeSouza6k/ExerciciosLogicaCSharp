using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Vetor
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Volvo", "Ford", "BMW", "Mazda"};
            carro[0] = "Opel"; //Substitui a posição [0] do vetor carro, o antigo valor era "Volvo", agora é "Opel"; 

            int[] numero = { 10, 20, 30, 40 };
            numero[0] = 50; //Substitui a posição [0] do vetor numero, o antigo valor era 10, agora é 50; 

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(carro[i]);
                
            }
            Console.WriteLine("\n\n");
            for (int j = 0; j < numero.Length; j++)
            {
                Console.WriteLine(numero[j]);
            }
        }
    }
}
