using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Desenvolvedor: Vinicius Veras
 * Data: 29/08/2015
 * Objetivo:
 * Ler 20 elementos númericos reais para uma matriz A, considerando que essa matriz tenha o tamanho de 4 linhas por
 * 5 colunas. Em seguida apresentar os dados lidos.*/


namespace ConsoleAppEX2
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = 4, colunas = 5;
            decimal[,] array_a = new decimal[linhas,colunas];
            int i = 0, j = 0;

            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.WriteLine("Insira na posição [{0}][{1}]: ", i, j);
                    array_a[i,j] = decimal.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("------------- Valores ------------------");
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.WriteLine("Posição [{0}][{1}]: {2:000} ", i, j, array_a[i,j]);
                   
                }
            }

            Console.ReadLine();
        }
    }
}
