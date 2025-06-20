using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FormarTriangulo
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            int[] lado= new int[3];
            for (int i = 0; i < lado.Length; i++)
            {
                Console.WriteLine($"Digite o valor dos três lados do triângulo.{contador}");
                lado[i] = Convert.ToInt32(Console.ReadLine());
                contador++;
            }
            string mensagem = (lado[0] + lado[1] > lado[2] && lado[2] + lado[1] > lado[0] && lado[0] + lado[2] > lado[1])
                ? $"É possível formar um triâgulo" : "Não é possível formar um triângulo";
            Console.Write(mensagem);    

        }
    }
}
