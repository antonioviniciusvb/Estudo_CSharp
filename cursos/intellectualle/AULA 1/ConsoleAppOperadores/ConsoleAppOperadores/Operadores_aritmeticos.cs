using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperadores
{
    class Operadores_aritmeticos
    {
        static void Main(string[] args)
        {
            float n1 = 10.5F, n2 = 9.4F; // Declarando Variavéis

            Console.WriteLine("--------------- Operadores Aritméticos ---------------");

            // soma
            Console.WriteLine("\n\nA soma dos valores {0} + {1} = {2} \n", n1, n2, n1 + n2);

            // Multiplicação
            Console.WriteLine("\nA Multiplicação dos valores {0} * {1} = {2} \n", n1, n2, n1 * n2);

            // Divisão 
            Console.WriteLine("\nA Divisão dos valores {0} / {1} = {2} \n", n1, n2, n1/n2);

            // Subtração
            Console.WriteLine("\nA Subtração dos valores {0} - {1} = {2} ", n1, n2, n1 - n2 + "\n\nDigite algo para encerrar..");
           


            Console.ReadLine(); 

        }
    }
}
