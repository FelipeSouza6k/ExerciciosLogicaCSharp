using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class PodeOuNaoVotar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ver se há permissão para votar");
            Console.WriteLine("Digite qual o ano que vc nasceu ");
            int ano = int.Parse(Console.ReadLine());
            int idade = 2025 - ano;
            string mensagem = (idade < 16) ? "Não pode votar"
                : (idade < 18) ? "Pode votar mas não é obrigatório" 
                :"O voto é obrigatório";

            Console.WriteLine(mensagem);
        }
    }
}
