using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp_Fatorial_preferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            long y = 1;

            Console.Title = "Programa Fatorial";
            Console.WriteLine("Entre um valor númerico: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            fatorial(x, ref y);

            Console.WriteLine("Fatorial de {0} = {1}", x, y);
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar...");
            Console.ReadKey();
            
        }

        public static void fatorial(int n, ref long fat)
        {
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
            }

        }
    }
}
