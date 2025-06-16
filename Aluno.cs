using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Aluno
    {
        public string idadeAluno;

        public Aluno(string idade)
        {
            idadeAluno = idade;
        }

        public static void Main(string[] args)
        {
            Aluno felipe = new Aluno("20");
            Console.WriteLine(felipe.idadeAluno);
        }
    }
}
