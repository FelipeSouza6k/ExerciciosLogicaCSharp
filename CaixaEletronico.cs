using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class CaixaEletronico
    {
        public static void Main(string[] args)
        {
            int[] notasDisponiveis = { 200, 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("Bem vindo ao banco. ");

            Console.Write("Digite o valor que deseja sacar: R$ ");

           
            if (!int.TryParse(Console.ReadLine(), out int valorSaque) || valorSaque <= 0)
            {
               Console.WriteLine("Valor inválido. Por favor, digite um número inteiro e positivo.");
                return;
            }
            Console.WriteLine("\nLiberando as seguintes notas:");
            Console.WriteLine("-----------------------------");

            int valorRestante = valorSaque;

            foreach (int nota in notasDisponiveis)
            {
                if (valorRestante >= nota)
                {
                   int quantidadeNotas = valorRestante / nota;
                    Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {nota}");

                    valorRestante %= nota;
                }
            }
             Console.WriteLine("-----------------------------");
            if (valorRestante > 0)
            {
                Console.WriteLine($"Não foi possível sacar o valor de R$ {valorRestante} com as notas disponíveis (R$ 1).");
            }

            Console.WriteLine("\nSaque finalizado. Volte sempre!");
        }
    }

}
