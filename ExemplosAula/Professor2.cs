using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Professor2
    {
        string nome = "Marcio";
        string nacionalidade = "Brasileira";
        string estado = "SP";

        public static void Main(string[] args)
        {
            Professor2 professor = new Professor2();
            Professor2 professor02 = new Professor2();

            Console.WriteLine($"Nome:{professor.nome}\n Nacionalidade:{professor.nacionalidade}\n Estado:{professor.estado}");

            professor02.nome = "Jailson";
            Console.WriteLine($"Nome:{professor02.nome}\nNacionalidade: {professor02.nacionalidade}\n Estado: {professor02.estado}");

        }
    }
}
