using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class LerValorPositivoNegativoOuZero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor e descubra se é negativo, positivo ou zero");
            int valor = int.Parse(Console.ReadLine());
            string mensagem = valor > 0 ? "Valor é positivo" : valor == 0 ? "Valor é zero" : "Valor é negativo"; 
            Console.WriteLine(mensagem);    
        }
    }
}
