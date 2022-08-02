using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp_fatorial_ppvalor
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Title = "Programa Fatorial";

            Console.Write("Entre um valor numerico: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            fatorial(x);


            Console.WriteLine("tecle algo para encerrar...");
            Console.ReadKey();

        }

        public static void fatorial(int n)
        {
            long fat = 1;

            if (n == 0)
            {
                fat = 0;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fat *= i;
                }

                Console.WriteLine("Fatorial de {0} = {1}", n, fat);
            }
        }
    }
}