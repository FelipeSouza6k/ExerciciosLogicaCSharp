using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class CalcularMediaAtividadesEProvas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calcular média aluno com 3 provas e média das atividades ");
            double[] notaAvaliacoes = new double[4];
            int contador = 1;
            for (int i = 0; i < notaAvaliacoes.Length; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Média das atividades em sala: ");
                    notaAvaliacoes[i] = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Digite a nota das provas: {contador}° prova ");
                    notaAvaliacoes[i] = Convert.ToDouble(Console.ReadLine());
                    notaAvaliacoes[i] *= contador;
                    contador++;
                }
            }
            double media = notaAvaliacoes.Sum() / 7;
            Console.WriteLine($"Média aluno: {media}");
            string mensagem = (media >= 9) ? "A"
                : (media >= 7.5) ? "B"
                : (media >= 6) ? "C"
                : "D";
            Console.WriteLine($" Conceito : {mensagem}");

        }
    }
}
