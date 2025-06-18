using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class TempoJogoDeXadrez
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calcular tempo de um jogo de xadrez ");

            Console.WriteLine("Digite o horário de ínicio da partida:  ");
            int inicioDaPartida = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o horário de término da partida:  ");
            int fimDaPartida = int.Parse(Console.ReadLine());
            string mensagem = (fimDaPartida > inicioDaPartida) ? $"{fimDaPartida - inicioDaPartida} horas"
                : $"{(24 - inicioDaPartida) + fimDaPartida} horas";

            Console.WriteLine(mensagem);
        }
    }
}
