using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Desenvolvedor: Vinicius Veras 
 * Data: 29/08/2015
 * Objetivo:
 * Ler 2 arrays do tipo vetor A com 5 elementos e B com 10 elementos (valores inteiros). Construir uma matriz C,
 * sendo esta a junção das duas outas matrizes. Dessa forma, C deve ter a capacidade de armazenar 15 elementos. 
 * Apresentar os elementos da matriz C*/


namespace ConsoleAppEX_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 10, min = 5;

            double[] array_a = new double[min], array_b = new double[max], array_c = new double[max + min];
            int i = 0, j = 0;

            Console.WriteLine("----------- Array A ---------------");
            for (i = 0; i < min; i++)
            {
                Console.WriteLine("\nDigite o {0}º número: ", i + 1);
                array_a[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("----------- Array B ---------------");
            for (i = 0; i < max; i++)
            {
                Console.WriteLine("\nDigite o {0}º número: ", i + 1);
                array_b[i] = double.Parse(Console.ReadLine());
            }

           
                for (i = 0; i < min; i++)
                {
                    array_c[i] = array_a[i];
                }
                for (i = min + 1; i < max + min; i++)
                {
                    array_c[i] = array_b[j];
                    j++;
                }

                Console.WriteLine("-------- ARRAY C  -----------");

            foreach (double elemento in array_c)
            {
                Console.WriteLine("{0}", elemento);
            }


            Console.ReadLine();
        }
    }
}
