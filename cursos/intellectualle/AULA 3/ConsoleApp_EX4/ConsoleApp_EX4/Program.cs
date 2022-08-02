using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Desenvolvedor: Vinicius Veras 
  Data: 18/09/2015
  Objetivo: 
  Faça um programa que receba uma matriz 5x5 valores do tipo int do usuário, um valor de cada vez, 
  e imprima a sua matriz transposta
  (Obs: a matriz transposta é obtida permutando-se as linhas e as colunas de uma matriz. */


namespace ConsoleApp_EX4
{
    class Program
    {

        static int linhas = 2;
        static int colunas = 2; 

        static void Main(string[] args)
        {
            int[,] array = new int[5,5], array_transposta = new int [linhas,colunas];
            int i = 0, j = 0, k = 0, l = 0;

            entrada(ref array, ref i, ref j);
           constroi_array_transposta(ref array, ref array_transposta,ref i, ref j,ref k, ref l);


            Console.ReadKey();
        }

        public static void entrada(ref int[,] array, ref int i, ref int j)
        {
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.WriteLine("Digite a posição [{0}][{1}] do array: ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }

            }
        }


        public static void constroi_array_transposta(ref int[,] array, ref int[,] array_transposta, ref int i, ref int j, ref int k, ref int l)
        {
            for (j = 0; j < linhas; j++)
            {
                for (i = 0; i < linhas; i++)
                {
                    for (k = 0; k < linhas ; k++)
                    {
                        for (l = 0; l < linhas; l++)
                        {
                            array_transposta[i, j] = array[l, k];
                        }
                    }
                    
                }
            }

            foreach (int item in array_transposta)
                {
                Console.WriteLine("{0}", item);
                }
        }
        }
    }

