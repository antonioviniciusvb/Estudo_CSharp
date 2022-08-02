using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx7___
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, numero2 = 0, i = 0, j = 0, k=0;
            string numero3;

            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            numero2 = numero - 1;

            for (i = numero2; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                    k++;
                }

                Console.WriteLine("");
            }

            Console.ReadLine();
        }

      //Função: Conta_caracteres

    public static string inserir(int n1)
        {


        }     

    }
}
