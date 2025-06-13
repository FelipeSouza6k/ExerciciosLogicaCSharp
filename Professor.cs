using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Professor
    {
        string nome = "Jailson";
        int idade = 40;

        public static void Main(string[] args)
        {
            Professor tecnologia = new Professor();
            Console.WriteLine("O nome do professor é: " + tecnologia.nome);
            Console.WriteLine("A idade do professor é: " + tecnologia.idade);
        }
    }
}
