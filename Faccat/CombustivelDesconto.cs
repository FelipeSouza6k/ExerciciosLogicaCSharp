using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class CombustivelDesconto
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Valor a ser pago pelo cliente por gasolina ou alcool");
            
            Console.WriteLine("Digite o tipo do combustivel. Gasolina (G) || Alcool(A)");
            char tipo = char.ToUpper(Convert.ToChar(Console.ReadLine()));
            Console.WriteLine("Digite quantos litros: ");
            double litros = Convert.ToSingle(Console.ReadLine());
            if (tipo == 'A')
            {
                if (litros < 20)
                {
                    double alcool = (2.90 - (2.90* 0.03));
                    double totalPedido = alcool * litros;
                    Console.WriteLine($"O total a ser pago é: R${Math.Round(totalPedido, 2)} ");
                }
                else
                {
                    double alcool = (2.90 - (2.90 * 0.05));
                    double totalPedido = alcool * litros;
                    Console.WriteLine($"O total a ser pago é: R${Math.Round(totalPedido,2)} ");
                }
            }
            else if (tipo == 'G')
            {
                if (litros < 20)
                {
                    double gasolina = (3.30 - (3.30 * 0.04));
                    double totalPedido = gasolina * litros;
                    Console.WriteLine($"O total a ser pago é: R${Math.Round(totalPedido, 2)} ");
                }
                else
                {
                    double gasolina = (3.30 - (3.30 * 0.06));
                    double totalPedido = gasolina * litros;
                    Console.WriteLine($"O total a ser pago é: R${Math.Round(totalPedido, 2)} ");
                }
            }
            else
            {
                Console.WriteLine("Tipo de combustivel inválido");
                return;
            }
        }
    }
}
