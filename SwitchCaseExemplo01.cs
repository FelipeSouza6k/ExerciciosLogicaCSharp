using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SwitchCaseExemplo01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para ver qual o dia da semana (Digite valores válidos de 1 a 7)\n\n");
            int diaDaSemana = Convert.ToInt16(Console.ReadLine());

            switch (diaDaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Valor Inválido");
                    break;
            }
        }
    }
}
