using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class CalcularMediaSimples
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calcular média do aluno");
            Console.WriteLine("Digite a nota do aluno: ");
            double[] notas = new double[2];
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"A média do aluno é: {notas.Sum() / notas.Length}");
        }
    }
}
