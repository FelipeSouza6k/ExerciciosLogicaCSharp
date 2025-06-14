using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class HoraExtraFuncionario
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calcular salário do funcionário por horas trabalhadas, e calcular hora extra se houver.");
            float salarioPorHora = 30.0F;
            Console.WriteLine("Digite o total de horas trabalhadas pelo funcionário");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            string mensagem = (horasTrabalhadas < 40) ? $"O salário do funcionário é : R${salarioPorHora * horasTrabalhadas}"
                : $"O salário do funcionário é : R${salarioPorHora * 40}\nE deverá ser acrescido: " +
                $"R$ {salarioPorHora * 1.5 * (horasTrabalhadas - 40)}";

            Console.WriteLine(mensagem);
        }
    }
}
