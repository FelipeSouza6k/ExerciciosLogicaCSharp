using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ComprarMacas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Venda de maçãs");
            Console.WriteLine("Quantidade de maçãs compradas");
            float maca = float.Parse(Console.ReadLine());
            string mensagem = (maca < 12) ? $" O valor total = R${maca * 1.3}" : $" O valor total: R${maca * 1}";
            Console.WriteLine(mensagem);
        }
    }
}
