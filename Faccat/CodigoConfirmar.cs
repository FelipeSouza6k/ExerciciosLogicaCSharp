using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica.Faccat
{
    internal class CodigoConfirmar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu código");
            int codigo = Convert.ToInt16(Console.ReadLine());
            while (codigo < 1000 || codigo > 9999)
            {
                Console.WriteLine("Código deve ter 4 digítos. Digite Novamente");
                codigo = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Confirme seu código: ");
            int codigoConfirmar = Convert.ToInt16(Console.ReadLine());
            string mensagem = (codigo != codigoConfirmar) ? "Código Incorreto" : "Acesso Liberado";
            Console.WriteLine(mensagem);
        }
    }
}
