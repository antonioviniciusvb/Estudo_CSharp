using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome; // declarando variavel 

            Console.WriteLine("Olá Mundo!!\nSou o C Sharp!!\n\nDigite o seu nome: "); // Escrevendo na tela

            nome = Console.ReadLine(); //  Recebendo o que foi digitado e armazenando na variavel string.nome


            Console.WriteLine("\nOlá, " + nome + "\nDigite algo para encerrar.."); //concatenando 
            Console.ReadLine(); // esperando alguma tecla para encerrar
        }
    }
}
