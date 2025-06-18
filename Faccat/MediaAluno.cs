using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MediaAluno
    {
        public static void Main(string[] args)
        {
            double[] notas = new double[3];
            int media = 10;

            Console.WriteLine(" Calcular média do aluno\n");
            Console.WriteLine("Digite as 3 notas do aluno ");

            for (int nota = 0; nota < notas.Length; nota++)
            {
                notas[nota] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o proximo valor: ");
            }
            notas[0] *= 2;
            notas[1] *= 3;
            notas[2] *= 5;
            Console.WriteLine($"A média do aluno é: {notas.Sum() / media } ");
        }
    }
}
