using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MetodosComMultiplosParametros
    {
        static void Informacoes(string nome, int idade)
        {
            Console.WriteLine($"O meu nome é {nome} e tenho {idade} anos");
        }
        public static void Main(string[] args) 
        {
            Informacoes("Felipe", 20);
            Informacoes("Jailson", 25);
            Informacoes("Negreiros", 62);
        }
    }
}
