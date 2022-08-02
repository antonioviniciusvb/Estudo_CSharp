using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Desenvolvedor: Vinicius Veras
 * Data: 29/08/2015
 * Objetivo: Ler 9 elementos reais para uma matriz A, considerando uma matriz com 3 linhas por 3 colunas 
 * .Em seguida apresentar os valores existentes na diagonal proncipal da matriz A multiplicados por 2 e os 
 * demais elementos por 3 */

namespace ConsoleAppEX5
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = 3, colunas = 3, i = 0, j =0;
            decimal[,] array_a = new decimal[linhas, colunas];


            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < linhas; j++)
                {
                    Console.WriteLine("Digite a posição [{0}][{1}]: ", i, j);
                    array_a[i, j] = decimal.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < linhas; j++)
                {
                    if (i != j)
                    {
                        array_a[i,j] = array_a[i,j] * 3;
                    }
                    else
                    {
                        array_a[i,j] = array_a[i,j] * 2;
                    }
                }
            }

            Console.WriteLine("------------ Exibição --------------");

            foreach (decimal elemento in array_a)
            {
                Console.WriteLine("{0}", elemento);
            }

            Console.ReadLine();
            
        }
    }
}
