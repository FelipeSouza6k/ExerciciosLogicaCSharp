using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class BreakContinue
    {
        public static void Break(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;//Ele encerra o programa 
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("\nFim Break\n");
        }
        public static void Continue(string[] args)
        {
            Console.WriteLine("Inicio Continue\n\n ");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;//Quando entrar nessa condição ele continua a executar o programa
                }
                Console.WriteLine(i);
            }
        }
    }
}
