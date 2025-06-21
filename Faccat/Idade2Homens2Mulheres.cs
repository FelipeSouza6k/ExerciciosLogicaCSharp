using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class Idade2Homens2Mulheres
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ler idade de dois homens e duas mulheres e fazer calculos ");
            int[] homem = new int[2];
            int[] mulher = new int[2];
            Console.WriteLine("Escreva a idade dos dois homens");
            for (int i = 0; i < homem.Length; i++) 
            { 
                homem[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Escreva a idade das duas mulheres");
            for(int j = 0; j < mulher.Length; j++)
            {
                mulher[j] = Convert.ToInt16(Console.ReadLine());
            }
            Array.Sort(homem);
            Array.Sort(mulher);
            Console.WriteLine($"A soma das idades do homem mais velho com a mulher mais nova é: {homem[1]} + {mulher[0]} = {homem[1] + mulher[0]}");
            Console.WriteLine($"Produto da idade do homem mais novo com a mulher mais velha : {homem[0]} * {mulher[1]} = {homem[0] * mulher[1]}");
        }
    }
}
