using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Temporizador
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temporizador");
            Console.WriteLine("Digite as horas: ");
            int horasDigitadas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os minutos: ");
            int minutosDigitados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os segundos: ");
            int segundosDigitados = Convert.ToInt32(Console.ReadLine());

            int minutos, segundos = 0;
            if (horasDigitadas > -1 && minutosDigitados < 60 && segundosDigitados < 60)
            {
                {
                    for (int hora = horasDigitadas; hora > -1; hora--)
                    {
                        for (minutos = minutosDigitados; minutos > -1; minutos--)
                        {
                            for (segundos = segundosDigitados; segundos > 0; segundos--)
                            {

                                Console.WriteLine($"{hora}h : {minutos}m : {segundos}s ");
                            }
                            segundos = 59;
                        }
                        minutos = 59;

                    }
                }
            }
            else
            {
                Console.WriteLine("Valor digitado inválido");
            }
        }
    }
}
