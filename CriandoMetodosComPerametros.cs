using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class CriandoMetodosComPerametros
    {
        static void Nome(string nome)
        {
            Console.WriteLine(nome + " Silva");
        }

        public static void Main(string[] args) 
        {
            Nome("Felipe");
            Nome("Gabriel");
            Nome("Julia");
        }
    }
}
