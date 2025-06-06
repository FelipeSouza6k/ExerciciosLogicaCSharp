using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ForEachExemplo02
    {
        public static void Main(string[] args)
        {
            string[] aluno = { "Rodrigues", "Ian", "Ferreira", "Laura"};

            foreach (string nome in aluno) { 
                Console.WriteLine(nome);    
            }
        }
    }
}
