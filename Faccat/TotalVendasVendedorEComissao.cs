using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class TotalVendasVendedorEComissao
    {
        public static void Main(string[] args)
        {
            double comissaoTotal = 1.03D;
            Console.WriteLine("Calcular salário do vendedor com comissão");
            Console.WriteLine("Digite o total de vendas desse funcionário (Se for maior que 1500 o valor que ultrapassar tera maior comissão)");
            double totalVenda = Convert.ToDouble(Console.ReadLine());
            string mensagem = (totalVenda > 1500) ? $"O valor total a ser recebido é: R${1500 * comissaoTotal + ((totalVenda - 1500) * 1.05)}"
                : $"O valor total a ser recebido é: R${totalVenda * comissaoTotal}";
            Console.WriteLine(mensagem);
        }
    }
}
