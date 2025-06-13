using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MetodoSobrecargaExemplo2
    {
         static int Soma(int valor1 , int valor2)
        {
            return valor1 + valor2;
        }
        static double Soma(double valor1, double valor2) 
        {
            return valor1 + valor2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores para efetuar a soma");
            Console.WriteLine("Digite o primeiro valor");

            double[] numero = new double [2];
            numero[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");

            numero[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O resultado da soma é: {numero[0] + numero[1]}");
        }
    }
}
