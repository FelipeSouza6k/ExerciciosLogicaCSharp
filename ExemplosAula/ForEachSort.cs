using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ForEachSort
    {
        public static void Main(string[] args)
        {
            string[] carro = {"BMW", "Volkswagen", "Hyunday", "Fiat" };
            Array.Sort(carro);
            int i = 0;
            foreach (string marca in carro)
            {
                i++;
                Console.WriteLine(marca);
            }
            Console.WriteLine(i);
        }
    }
}
