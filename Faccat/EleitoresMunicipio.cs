using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class EleitoresMunicipio
    {
        public static void Main(string[] args)
        {
            int totalEleitores, votosValidos, votosBrancos, votosNulos;
            Console.WriteLine("Ler numero de eleitores e calcular tipos de votos ");
            Console.WriteLine("Digite o total de eleitores: ");
            totalEleitores = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o total de votos válidos: ");
            votosValidos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o total de votos brancos: ");
            votosBrancos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o total de votos nulos: ");   
            votosNulos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Total de eleitores: {totalEleitores}");
            Console.WriteLine($"Porcentagem de votos válidos: {(votosValidos * 100) / totalEleitores} %");
            Console.WriteLine($"Porcentagem de votos brancos: {(votosBrancos * 100) / totalEleitores} %");
            Console.WriteLine($"Porcentagem de votos nulos: {(votosNulos * 100) / totalEleitores} %");
        }
    }
}
