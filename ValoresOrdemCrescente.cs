using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ValoresOrdemCrescente
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ler dois valores e mostrar qual o maior");
            int[] numero = new int[2];
            int maior = 0, menor = 0;
            Console.WriteLine("Digite o primeiro valor: ");
            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                if (numero[0] > numero[1])
                {
                    maior = numero[0];
                    menor = numero[1];
                }
                else
                {
                    maior = numero[1];
                    menor = numero[0];
                }
            }
            Console.WriteLine($"{menor}, {maior}");
        }
    }
}