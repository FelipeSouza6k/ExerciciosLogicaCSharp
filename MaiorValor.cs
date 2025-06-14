using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MaiorValor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ler dois valores e mostrar qual o maior");
            int[] numero = new int[2];
            int maior = -999999999;
            Console.WriteLine("Digite o primeiro valor: ");
            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                if(numero[i] > maior)
                {
                   maior = numero[i];
                }
            }
            Console.WriteLine($"O maior número é: {maior}");
        }
    }
}
