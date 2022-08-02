using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppEX9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 3;
            int i = 0, numero = 0, cont_npares = 0, cont_nimpares = 0, controle = 0, soma_pares = 0, soma_impares = 0;


            Console.WriteLine("------------- Insira 20 valores Inteiros -------\n");

            do
            {
                try
                {
                    for (i = 0; i < max; i++)
                    {
                        Console.WriteLine("Digite o {0}º numero: ", i + 1);
                        numero = int.Parse(Console.ReadLine());

                        if (numero % 2 == 0)
                        {
                            cont_npares++;

                            soma_pares = calcula_pares(numero);
                            
                        }
                        else
                        {
                            cont_nimpares++;
                            soma_impares = calcula_impares(numero);
                        }

                        controle = 1;

                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine("ERRO !! Verifique  o valor inserido.");

                }


            } while (controle != 1);


            Console.WriteLine("--------------- Exibição _-_ Pares  ---------------");
            Console.WriteLine("Somatória = {0}", soma_pares);
            Console.WriteLine("Qntde     = {0}", cont_npares);

            Console.WriteLine("--------------- Exibição _-_ Ímpares  ---------------");
            Console.WriteLine("Somatória  = {0}", soma_impares);
            Console.WriteLine("Qntde      = {0}", cont_nimpares);

            Console.ReadLine();
        }

        public static int calcula_pares(int n1)
        {
            int ac_pares = 0;

            return (ac_pares = ac_pares + n1);
        }

        public static int calcula_impares(int n1)
        {
            int ac_impares = 0;
            return (ac_impares = ac_impares + n1);
        }

    }
}
