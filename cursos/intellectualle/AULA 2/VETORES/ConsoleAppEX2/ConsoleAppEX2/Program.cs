using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Desenvolevedor: Vinicius Veras
 * Data: 29/08/2015
 * OBjetivo: 
 * Ler 2 arryas[1] A e B do tipo Vetor com 20 elementos númericos inteiros. Construir uma matriz C, sendo 
 * cada elemento de C, sendo a subtração do elemento correspondente de A com B. Apresentar os elementos da matriz C.*/


namespace ConsoleAppEX2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 5;
            int[] array_a = new int[max], array_b = new int[max], array_c = new int[max];
            int i = 0;


            Console.WriteLine("------ Inserindo Dados ARRAY A -----------");

            for (i = 0; i < max; i++)
            {

                Console.WriteLine("\nDigite o {0}º da Array A: ", i+1);
                array_a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("------ Inserindo Dados ARRAY B -----------");

            for (i = 0; i < max; i++)
            {

                Console.WriteLine("\nDigite o {0}º da Array B: ", i +1);
                array_b[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < max; i++)
            {
                array_c[i] = (array_a[i] - array_b[i]);
            }


            Console.WriteLine("---------- ARRAY A ---------------");

            i = 0;

            foreach (int elemento in array_a)
            {
                Console.WriteLine("Posição {0}: {1}", i + 1, elemento);
                i++;
            }

            Console.WriteLine("---------- ARRAY B ---------------");

            i = 0;

            foreach (int elemento in array_b)
            {
                Console.WriteLine("Posição {0}: {1}", i + 1, elemento);
                i++;
            }

            Console.WriteLine("---------- ARRAY C ---------------");
             i = 0;

            foreach (int elemento in array_c)
            {
                Console.WriteLine("Posição {0}: {1}", i + 1, elemento);
                i++;
            }


            Console.WriteLine("Tecle algo para encerrar..");
            Console.ReadLine();
        }
    }
}
