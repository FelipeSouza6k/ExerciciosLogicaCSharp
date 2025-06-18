using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class LerIdade
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ler idade de uma pessoa em anos, meses, dias e transformar somente em dias. ");
            int anos, meses, dias, totalDias;
            Console.WriteLine("Digite a idade em anos: ");
            anos =Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite a idade em meses: ");
            meses = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite a idade em dias: ");
            dias = Convert.ToInt16(Console.ReadLine());
            totalDias = (anos * 365) + (meses * 30) + dias;
            Console.WriteLine($"A idade dessa pessoa em dias = {totalDias} dias");
        }
    }
}
