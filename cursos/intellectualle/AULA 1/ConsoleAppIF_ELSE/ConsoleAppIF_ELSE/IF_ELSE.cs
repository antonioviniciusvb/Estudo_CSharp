using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIF_ELSE
{
    class IF_ELSE
    {
        static void Main(string[] args)
        {
            int n1; //Declarando Variavéis

            // Capitando valor
            Console.WriteLine("Digite um valor: ");
            n1 = int.Parse(Console.ReadLine());



            // Condição 
            if (n1 > 100)
            {
                Console.WriteLine("O valor {0} ", n1 + " é maior que 100");
            }
            else
              if(n1 == 100)
                {
                    Console.WriteLine("O valor {0}", n1 + " é igual a 100");
                }
                else
                 {
                    Console.WriteLine("O valor {0}" , n1 + " é menor que 100");
                 }

                     Console.ReadLine();
        }
    }
}
