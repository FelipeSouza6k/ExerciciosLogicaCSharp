using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SubString
    {
        public static void Main(string[] args)
        {
            string texto = "C# programação é divertida!";

            // Usando Substring(startIndex)
            string parte1 = texto.Substring(3); // Começa do índice 3 (o espaço após 'C#') até o final
            Console.WriteLine($"Substring a partir do índice 3: \"{parte1}\""); // Saída: " programação é divertida!"

            // Usando Substring(startIndex, length)
            string parte2 = texto.Substring(0, 2); // Começa do índice 0, pega 2 caracteres
            Console.WriteLine($"Substring do índice 0, comprimento 2: \"{parte2}\""); // Saída: "C#"

            string parte3 = texto.Substring(18, 9); // Começa do índice 18 ('d'), pega 9 caracteres
            Console.WriteLine($"Substring do índice 18, comprimento 9: \"{parte3}\""); // Saída: "divertida"

            // Exemplo de como evitar ArgumentOutOfRangeException
            int inicioDesejado = 25;
            int comprimentoDesejado = 10;
            if (inicioDesejado >= 0 && inicioDesejado < texto.Length && (inicioDesejado + comprimentoDesejado) <= texto.Length)
            {
                string parte4 = texto.Substring(inicioDesejado, comprimentoDesejado);
                Console.WriteLine($"Substring segura: \"{parte4}\"");
            }
            else
            {
                Console.WriteLine("Não foi possível extrair a substring devido a índices/comprimento inválidos.");
            }
        }
    }
}
