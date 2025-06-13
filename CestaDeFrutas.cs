using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    public class CestaDeFrutas
    {
        public static void Main(string[] args)
        {
            Fruta fruta = new Fruta();
            Console.WriteLine($"Fruta: {fruta.nome}\n Preço: R${fruta.preco}");
            
        }
    }
}
