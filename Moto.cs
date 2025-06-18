using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Moto
    {
        public string modelo;
        public int ano;
        public string placa;

        public Moto(string modeloMoto, int anoMoto, string placaMoto)
        {
            modelo = modeloMoto;
            ano = anoMoto;
            placa = placaMoto; 
        }
        public static void Main(string[] args)
        {
            Moto hyunday = new Moto("Motinha de 2 rodas", 2012, "2R3456");
            Console.WriteLine($"Modelo: {hyunday.modelo}\nAno: {hyunday.ano}\nPlaca: {hyunday.placa}\n");
        }
    }
}
