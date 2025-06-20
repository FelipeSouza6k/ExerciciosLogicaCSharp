using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class VencedorDaPartida
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            Console.WriteLine("Quem venceu a partida");
            int[] time = new int[2];
            for (int i = 0; i < time.Length; i++)
            {
                Console.WriteLine($" Gols do {contador}° time");
                time[i] = Convert.ToInt16(Console.ReadLine());
                contador++;
            }
            string mensagem = (time[0] > time[1]) ? $"O 1° time foi o vencedor"
                : (time[1] > time[0]) ? "O 2° time foi o vencedor" : "Empate";
            Console.WriteLine(mensagem);
        }
    }
}
