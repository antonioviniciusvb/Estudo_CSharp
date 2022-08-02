using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEX10
{
    class Program
    {
        static void Main(string[] args)
        {

            const int max = 10;
            int i=0, controle = 0;
            double numero = 0, ac_valores = 0;

            Console.WriteLine("--------Insira 10 Números Pares--------\nObs:Entre com Qualquer Número Ímpar para cancelar.\n");

            do
            {
                try
                {
                    for (i = 0; i < max; i++)
                    {
                        Console.WriteLine("Digite o {0}º número: ", i + 1);
                        numero = double.Parse(Console.ReadLine());


                        if(numero % 2 == 0)
                        {
                            ac_valores = soma_valores(ac_valores, numero);
                        }
                        else
                        {
                            Console.WriteLine("Inserção encerrada !");

                            controle = 1; // controle de saída do while
                            
                            break;

                        }
                             controle = 1; // controle de saída do while 
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine("ERRO!! Verifique o valor inserido.");

                }

            } while (controle != 1);

            Console.WriteLine("-------- Somatória dos Valores ----------");
            Console.WriteLine("\t\t{0}", ac_valores);



                 Console.ReadLine();
        }

        /*
        Função: soma_valores
        Objetivo: somar valores
        Parâmetros: double n1, double n2
        Return: double n1 */

        public static double soma_valores (double n1, double n2)
        {

            return (n1 = n1 + n2);

        }
    }
}
