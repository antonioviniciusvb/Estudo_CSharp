using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Desenvolvedor: Vinicius Veras
    DATA: 28/08/2015
    Objetivo:
    Algoritmo que leia uma quantidade não determinada de números positivos.
    Calcule a quantidade de números pares e ímpares, a média de valores pares,
    a média geral dos números lidos. O número que encerrará a leitura será zero.*/

namespace ConsoleAppEX5
{
    class Program
    {
        static void Main(string[] args)
        {
            // variáveis 

            int numero = 1, cont_par = 0, cont_impar = 0;


            Console.WriteLine("OBS: O número 0 encerra a entrada de dados.");

            while (numero != 0)
            {
                Console.WriteLine("\nDigite o número: ");
               
                numero = int.Parse(Console.ReadLine());

                if(numero % 2 == 0)
                {
                    cont_par++;
                   
                }
                else
                {
                    cont_impar++;
                }
            }


            Console.WriteLine("---------Exibição -----------");
            Console.WriteLine("Números Pares: {0}", cont_par);
            Console.WriteLine("Números Impares: {0}", cont_impar);
            Console.ReadLine();
          
        }
    }
}
