using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Desenvolvedor: Vinicius VEras 
 * Data: 29/08/2015
 * Objetivo:
 * Ler 2 matrizes A e B com valores reias cada uma de 2 dimensões com 4 linhas e 4 colunas. Construir uma matriz C
 * de mesma dimensão, a qual é formada pela substração dos elementos da matriz A dos elementos da matriz B. Apresentar
 * os valores da matriz C.*/


namespace ConsoleAppEX_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = 4, colunas = 4, i = 0, j = 0;
            decimal[,] array_a = new decimal[linhas, colunas], array_b = new decimal[linhas,colunas], array_c = new decimal[linhas,colunas];

            for(i = 0; i < linhas; i++)
            {
                for(j = 0; j < colunas; j++)
                {

                    Console.WriteLine("Insira a posição [{0}][{1}] do ARRAY A: ", i,j);
                    array_a[i,j] = decimal.Parse(Console.ReadLine());
                }
            }

            for(i = 0; i < linhas; i++)
            {
                for(j = 0; j < colunas; j++)
                {

                    Console.WriteLine("Insira a posição [{0}][{1}] do ARRAY B : ", i,j);
                    array_b[i,j] = decimal.Parse(Console.ReadLine());
                }
            }

            for(i = 0; i < linhas; i++)
            {
                for(j = 0; j < colunas; j++)
                {
                   array_c[i,j] = array_b[i,j] - array_a[i,j];
                }
            }


            Console.WriteLine("\n---------- Exibição -------------------\n\n-------------- Array A ----------------\n");
             for(i = 0; i < linhas; i++)
            {
                for(j = 0; j < colunas; j++)
                {
                   Console.WriteLine("Posição {0}{1}: {2}", i,j, array_a[i,j]);
                }
            }

             Console.WriteLine("---------------- Array B ----------------\n");
             for(i = 0; i < linhas; i++)
            {
                for(j = 0; j < colunas; j++)
                {
                   Console.WriteLine("Posição {0}{1}: {2}", i,j, array_b[i,j]);
                }
            }
             
            Console.WriteLine("---------------- Array C ---------------\n");
            for(i = 0; i < linhas; i++)
            {
                for(j = 0; j < colunas; j++)
                {
                   Console.WriteLine("Posição {0}{1}: {2}", i,j, array_c[i,j]);
                }
            }

            Console.ReadKey();
        }
    }
}
