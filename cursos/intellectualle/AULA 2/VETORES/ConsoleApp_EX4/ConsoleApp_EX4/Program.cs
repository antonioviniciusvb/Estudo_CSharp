using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Densevolvedor: Vinicius Veras
 * Data: 29/08/2015
 * Objetivo:
 * Ler 15 números inteiros de um array[1] A. Construir uma matriz B de mesmo tipo, observando a 
 * seguinte lei de formação: todo elemento da matriz B deve ser o quadrado do elemento correspondente 
 * da matriz da matriz A.Apresentar os elementos das matrizes A e B dispostos lado a lado*/

namespace ConsoleApp_EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 15;
            int[] array_a = new int[max], array_b = new int[max];

            int i = 0;

            for(i = 0; i < max; i++)
            {
                Console.WriteLine("\nDigite o {0}º número: ", i+1);
                array_a[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < max; i++)
            {
                array_b[i] = (array_a[i] * array_a[i]);
            }


            Console.WriteLine("---------------- Exibição ----------------------\n\nArray A                         Array B\n\n");

            for (i = 0; i < max; i++)
            {               
                Console.WriteLine("Posição {0:00}:  {1:0000}                {2:0000}   ",i, array_a[i], array_b[i]);
            }

            Console.ReadLine();
        }
    }
}
