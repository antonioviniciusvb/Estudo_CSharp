using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Desenvolvedor: Vinicius Veras
 * Data: 29/08/2015
 * Objetivo:
 * Ler 16 elementos numéricos reais para uma matriz A, considerando uma matriz com 4 linhas por 4 colunas. Em 
 * seguida apresentar os valores existentes na diagonal principal da matriz A. */


namespace ConsoleAppEX_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = 4, colunas = 4, i = 0, j = 0;
            decimal[,] array = new decimal[linhas, colunas];

            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.WriteLine("Posição [{0}][{1}]: ", i, j);
                    array[i, j] = decimal.Parse(Console.ReadLine());
                }
            }

            //diagonal 

            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine("Posição:{2} ", i, j, array[i, j]);
                    }
                }
            }

            //secundaria

            Console.WriteLine("\n\n");
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (j == (4 - 1 - i))
                        {
                            Console.WriteLine("Posição:{2}", i, j, array[i, j]);
                        }
                    }
                }

                Console.ReadLine();
            }
        }
    }

    
       
