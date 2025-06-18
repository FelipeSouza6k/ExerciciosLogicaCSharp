using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class CalcularSalarioVendedor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calcular valor do salário do funcionário com base nos carros vedidos \n\n");
            Console.WriteLine("Digite o total de vendas do funcionário");
            double totalvendas = Convert.ToDouble(Console.ReadLine());
            totalvendas *= 0.03;
            Console.WriteLine($"Comissão das vendas : {totalvendas}\n\n");

            Console.WriteLine("Digite o salário do funcionário: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Salário : {salario}");

            Console.WriteLine("Digite quantos carros foram vendidos pelo funcionário: ");
            double quantCarros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Vendeu : {quantCarros}");


            Console.WriteLine($"O salário deste funcionário será de: {salario + (salario * 0.01) * quantCarros + totalvendas } ");
            
        }
    }
}
