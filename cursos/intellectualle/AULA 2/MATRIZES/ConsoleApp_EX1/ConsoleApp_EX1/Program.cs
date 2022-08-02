using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Desenvolvedor: Vinicius Veras
 * Data: 29/08/2015
 * Objetivo:
 * Ler 2 arrays[,] com valores inteiros cada uma de duas dimensões com 5 linhas e 3 colunas. Construir uma 
 * matriz C de mesma dimensão, a qual é formada pela soma dos elementos da matriz A com os elementos da matriz B.
 * Apresentar os elementos da matriz C.*/


namespace ConsoleApp_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int linhas = 5, colunas = 3;
            int[,] array_a = new int[linhas,colunas], array_b = new int[linhas,colunas], array_c = new int[linhas,colunas];
            int i = 0, j = 0;

            // ---------------- Entrada de Dados das Matrizes -------------
            Console.WriteLine("-----------  ARRAY A  -------------");
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.WriteLine("\nDigite o [{0}][{1}] número : ", i, j);
                    array_a[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("------------ ARRAY B ----------------");
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.WriteLine("\nDigite o [{0}][{1}] número: ", i, j);
                    array_b[i, j] = int.Parse(Console.ReadLine());
                }
            }
           
            // ------------------ ARRAY C -------------------------------
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    array_c[i, j] = array_a[i, j] + array_b[i, j];
                }
            }


            Console.WriteLine("----------------- Exibição -----------------\n-------------ARRAY A -------------\n");

            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.WriteLine("Posição [{0}][{1}]: {2}", i, j, array_a[i, j]);
                }
            }


            Console.WriteLine("-------------ARRAY B -------------\n");
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.WriteLine("Posição [{0}][{1}]: {2}", i, j, array_b[i, j]);
                }
            }

            Console.WriteLine("-------------ARRAY C -------------\n");
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.WriteLine("Posição [{0}][{1}]: {2}", i, j, array_c[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
}
