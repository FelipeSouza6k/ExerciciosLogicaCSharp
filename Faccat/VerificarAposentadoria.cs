using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class VerificarAposentadoria
    {
        public static void Main(string[] args)
        {
            int ano = 2025;
            Console.WriteLine("Verficar se o funcionários esta apto a se aposentar");
            Console.WriteLine("Ano de nascimento do usuário: ");
            int anoNascimentoFuncionario = Convert.ToInt16(Console.ReadLine());
            int idade = ano - anoNascimentoFuncionario;
            Console.WriteLine("Ano de ingresso do funcionário: ");
            int anoIngressoFuncionario = Convert.ToInt16(Console.ReadLine());
            int tempoEmpresaFuncionario = ano - anoIngressoFuncionario;
            string mensagem = (idade > 64 || idade > 60 && tempoEmpresaFuncionario > 25 || tempoEmpresaFuncionario > 30)
                ? "Requerer aposentadoria"
                : "Não requerer aposentadoria";
            Console.WriteLine(mensagem);
        }
    }
}
