using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Desenvolvedor: Vinicius Veras
 * Data: 29/08/2015
 * Objetivo: 
 * ler 8 números interios em uma array tipo vetor.Construir uma matriz B da mesma dimensão com os
 * elementos da matriz.A multiplicados por 3. Apresentar os elementos da matriz B.*/


namespace ConsoleAppEx1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            //variáveis
            const int max = 8;
            int i = 0;
            int[] array_a = new int[8], array_b = new int[8];

            // capitando os dados 
            for (i = 0; i < max; i++)
            {

                Console.WriteLine("\nDigite o {0}º número: ", i + 1);
                array_a[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("------ Array A -----------");
            
            i = 0;

            foreach (int elemento in array_a)
            {

                Console.WriteLine("Posição {0}:  {1}", i+1, elemento);
                i++;
            }


            for (i = 0; i < max; i++)
            {
                array_b[i] = array_a[i] * 3;
            }

            Console.WriteLine("-------- Array B ------------");

            i = 0;

            foreach (int elemento in array_b)
            {
                Console.WriteLine("Posição {0}: {1}", i+1, elemento);
                i++;
            }
            Console.ReadLine();
 

        }
    }
}
