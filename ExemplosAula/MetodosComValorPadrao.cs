using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MetodosComValorPadrao
    {
        static void Pais(string pais = "Brasil")
        {
            Console.WriteLine($"Localidade : {pais}");
        }

        public static void Main(string[] args) 
        {
            Pais("Estados Unidos");
            Pais("China");
            Pais("Russia");
            Pais();
        }
    }
}
