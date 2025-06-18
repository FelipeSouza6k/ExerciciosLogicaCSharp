using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Exemplo02IfTernario
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplo If Ternário\n");
            Console.WriteLine("Verficar se há idade para votar\n");
            Console.WriteLine("Digite a idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            string verificar = (idade < 16) ? "Não pode votar." : (idade < 18) ? "Voto opcional" : "Voto obrigatório";
            Console.WriteLine(verificar);
        }
    }
}
