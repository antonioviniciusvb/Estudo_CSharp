using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Desenvolvedor: Vinicius Veras 
 * Data: 29/08/2015
 * Objetivo:
 * Ler 20 elementos interios para uma array A e construir uma matriz B de mesma dimensão com os mesmos elementos de A.
 * Eles devem estar invertidos, ou seja, o primeiro elemento de A passa a ser o último de B, o segundo elemento de A passa
 * a ser o último de B, o segundo elemento de A passa a ser o penúltimo de B e assim por diante.
 * Apresentar os elementos das duas arrays*/

namespace ConsoleAppEX_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 5;
            int i = 0, j = 0;
            int[] array_a = new int[max], array_b = new int[max];

            for (i = 0; i < max; i++)
            {

                Console.WriteLine("\nDigite o {0}º número: ", i + 1);
                array_a[i] = int.Parse(Console.ReadLine());
            }

            for (i = max -1; i >= 0; i--)
            {
                array_b[j] = array_a[i];
                j++;
            }

           /* foreach (int elemento in array_b)
            {
                Console.WriteLine("{0}", elemento);
            }*/


            Console.WriteLine("----------------- Exibição  ---------------------\n  ARRAY A                  ARRAY B\n");
            for (i = 0; i < max; i++)
            {
                Console.WriteLine("Posição {0:00}: {1:00000}         {2:00000}", i, array_a[i], array_b[i]);
            }

            Console.ReadLine();


        }
    }
}
