using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class Ler3ValoresOrdemCrescente
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores e eles serão escritos em ordem crescente");
            int[] valor = new int[3];
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine("Digite um valor");
                valor[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(valor);
            Console.WriteLine("Valores em ordem crescente: ");
            foreach(int i in valor)
            {
                Console.Write(i+ "\t");
            }
        }
    }
}
