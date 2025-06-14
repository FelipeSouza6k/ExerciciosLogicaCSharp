using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class PositivoOuNegativo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ver se o valor é positivo ou negativo ");
            int numero = int.Parse(Console.ReadLine());
            string mensagem = (numero < 0) ? "Este numero é negativo." : "Este número é positivo.";
            Console.WriteLine(mensagem);
            
        }
    }
}
