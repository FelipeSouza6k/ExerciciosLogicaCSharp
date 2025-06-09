using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExerciciosLogica
{
    internal class FileCreate
    {
        public static void Main(string[] args)
        {
            //Criando o arquivo e adicionando o texto
            File.WriteAllText("File.txt", "Olá Mundo");

            string conteudo = "Segundo arquivo";
            File.WriteAllText("Arquivo.txt", conteudo);

            Console.WriteLine("Arquivos criados com sucesso");

        }
    }
}
