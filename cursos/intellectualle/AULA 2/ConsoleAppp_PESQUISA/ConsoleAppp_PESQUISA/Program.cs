using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppp_PESQUISA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[5];
            int i;
            string pesq;

            // Entrada de dados

            Console.Clear();
            for (i = 0; i <5; i++)
            {

                Console.WriteLine("\nEntre o {0,2}º. nome:", i + 1);
                a[i] = Console.ReadLine();
            }
            
            // pesquisa
            Console.WriteLine("\nEntre nome a pesquisar: ");
            pesq = Console.ReadLine();
            i = Array.IndexOf(a, pesq);

            if (i >= 0)
            {
                Console.WriteLine("\n{0} foi localizado", pesq);
                Console.WriteLine("na posição {0}.", i + 1);
            }
            else
            {
                Console.WriteLine("\n{0} não foi locazido.", pesq);
            }

            Console.WriteLine("\nTecle algo para encerrar...");
            Console.ReadLine();


        }
    }
}
