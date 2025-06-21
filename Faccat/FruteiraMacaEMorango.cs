using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class FruteiraMacaEMorango
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calcular preço da compra");
            Console.WriteLine("Quantidade de morango comprada:");
            float morangoComprado = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Quantidade de maçã comprada:");
            float macaComprado = Convert.ToSingle(Console.ReadLine());
            float pesoTotal = morangoComprado + macaComprado;
            float precoMorango, precoMaca;

            if (morangoComprado < 5 && morangoComprado > 0)
            {
                precoMorango = 2.5F * morangoComprado;
            }
            else
            {
                precoMorango = 2.1F * morangoComprado;
            }
            Console.WriteLine($"Valor do morango: R${precoMorango}");

            if (macaComprado < 5 && macaComprado > 0)
            {
                precoMaca = 1.8F * macaComprado;
            }
            else
            {
                precoMaca = 1.5F * macaComprado;
            }
            Console.WriteLine($"Valor da maçã: R${precoMaca}");
            float precoTotal = precoMorango + precoMaca;
            if (precoTotal > 25 || pesoTotal > 8)
            {
                precoTotal -= (precoTotal * 0.10F);
                Console.WriteLine($"Preço total : R${precoTotal}   DESCONTO:{precoTotal * 0.10F}");
            }
            else
            {
                Console.WriteLine($"Preço total : R${precoTotal}");
            }
        }
    }
}
