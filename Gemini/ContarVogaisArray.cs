using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ContarVogaisArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Contagem de vogais em uma palavra");
            Console.WriteLine("Digite uma palavra ");
            string palavra = Console.ReadLine();
            palavra = palavra.ToLower();
            int contadora = 0;
            Console.WriteLine("As vogais são: ");
            for (int i = 0;  i < palavra.Length; i++)
            {
                if (palavra[i] == 'a' || palavra[i] == 'e' || palavra[i] == 'i' || palavra[i] == 'o' || palavra[i] == 'u')
                {
                    Console.Write($" {palavra[i]}");
                    contadora++;
                }
            }
            Console.WriteLine($"\n\nNesta palavra há {contadora} vogais");
        }
    }
}
