using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class CriacaoVetores
    {
        public static void Main(string[] args)
        {
           //Usuário atribui o valor para uma váriavel que não tem valores definidos.

            string[] carro = new string[4];//Está é uma variável sem valores definidos, mas tem espaços que ainda não foram preenchidos;

            for (int i = 0; i < carro.Length; i++)
            {
                Console.WriteLine("Digite o nome do carro: ");
                carro[i] = Console.ReadLine();
            }

            for (int i = 0; i < carro.Length; i++)
            {
                Console.WriteLine($"\n\n\n{carro[i]}");
            }
            


            int[] numero = new int[4] { 10, 20, 30, 40 };


            string[] alunos = new string[] { "Felipe Rodrigues", "Breno", "De Souza", "Rose" };


            int[] sala = { 38, 45, 17, 25 };



        }
    }
}
