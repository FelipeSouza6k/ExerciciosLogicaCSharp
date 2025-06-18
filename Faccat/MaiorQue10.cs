using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MaiorQue10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escreva um valor e verifique se é maior que 10: ");
            int numero = int.Parse(Console.ReadLine());
            string mensagem = (numero > 10) ? "Este número é maior que 10." : "Este número é menor que 10";
            Console.WriteLine(mensagem);
        }
    }
}
