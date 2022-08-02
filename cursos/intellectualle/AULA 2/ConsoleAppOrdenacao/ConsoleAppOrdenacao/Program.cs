using System;

namespace ConsoleAppOrdenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[10];
            int i;

            //Entrada de Dados
            
            Console.Clear();

            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine("Entre o {0,2}º.nome:", i + 1);
                a[i] = Console.ReadLine();
            }
            
            //Ordenação
            Array.Sort<string>(a);
            //Array.Reverse(a);
            Console.WriteLine();

            // Apresentação ordenada 
            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine("{0,2}º. nome = {1}", i + 1, a[i]);
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar...");
            Console.ReadKey();
        }
    }
}
