using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[5];
            int i = 0;

            for (i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Digite o {0}º número: ", i+1);
                numero[i] = int.Parse(Console.ReadLine());

            }

            for (i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Posição {0}: {1}", i, numero[i]);
            }

            foreach (int elemento in numero)
            {
                Console.WriteLine(elemento);
            }

            Console.ReadLine();

        }
    }
}
