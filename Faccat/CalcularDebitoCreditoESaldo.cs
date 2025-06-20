using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class CalcularDebitoCreditoESaldo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ler saldo bancário do cliente");
            Console.WriteLine("Digite seu saldo atual");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite saldo em débito");
            double debito= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite saldo em Crédito");
            double credito= Convert.ToDouble(Console.ReadLine());
            double saldoAtual = saldo - debito + credito;
            string mensagem = (saldoAtual > 0) ? $"Saldo atual: R${saldoAtual}\nSaldo Positivo" : $"Saldo atual" +
                $": R${saldoAtual}\nSaldo Negativo";
            Console.WriteLine(mensagem);


        }
    }
}
