using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ExemploIfElseIf
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplos If, Else, Elseif\n");
            int idade;
            Console.WriteLine("Digite a sua idade, para ver se esta apto ou não votar.\n");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 16)
            {
                Console.WriteLine("Não tem idade o suficiente para votar\n");
            }
            else if(idade < 18)
            {
                Console.WriteLine("Pode votar mas não é obrigatório\n");
            }
            else
            {
                Console.WriteLine("É obrigado a votar\n");
            }
        }
    }
}
