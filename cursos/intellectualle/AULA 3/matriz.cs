Leia uma matriz A(3 x 3)  e gere a sua matriz transposta

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5-Leia uma matriz A(3 x 3)  e gere a sua matriz transposta");
            Console.WriteLine("(a matriz transposta é aquela onde o que era linha na matriz original passa a ser coluna e vice-versa).");
            Console.WriteLine();

            const int tl = 3, tc = 3;
            int[,] matriz = new int[tl, tc];
            int linha = 0, coluna = 0;

            Console.WriteLine("ENTRADA DE DADOS");
            Console.WriteLine();

            for (linha = 0; linha < tl; linha++)
            {
                Console.WriteLine("LINHA - ["+ (linha + 1) +"]");
                for (coluna = 0; coluna < tc; coluna++)
                {
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.WriteLine("IMPRESSÃO DA MATRIZ");

            for (linha = 0; linha < tl; linha++)
            {
                Console.SetCursorPosition(7,21 + linha);
                for (coluna = 0; coluna < tc; coluna++)
                {
                    Console.Write(matriz[linha,coluna]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("MATRIZ TRANSPOSTA");

            for (linha = 0; linha < tl; linha++)
            {
                Console.SetCursorPosition(7, 26 + linha);
                for (coluna = 0; coluna < tc; coluna++)
                {
                    Console.Write(matriz[coluna,linha]);
                }
            }
            Console.ReadKey();
        }
    }
}