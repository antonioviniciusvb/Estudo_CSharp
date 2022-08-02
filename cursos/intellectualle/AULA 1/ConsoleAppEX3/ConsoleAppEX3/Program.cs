using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEX3
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIÁVEIS 
            Double n_farenheit = 0, n_celsius = 0;
            int controle = 0;

                Console.WriteLine("Conversor ---  Farenhiet para Celsius ");
            do
            {
                try
                {
                    Console.WriteLine("Digite valor a ser convertido: ");
                    n_farenheit = double.Parse(Console.ReadLine());

                    controle = 1;
                }
                catch (Exception erro)
                {
                    Console.WriteLine("ERRO !! Verifique valor digitado.");
                    Console.WriteLine("{0}", erro);
                }

            } while (controle != 1);

            // chamada da função
               n_celsius =  converte_farenheit_p_celsius(n_farenheit);

            // exibição
            Console.WriteLine("---------Valores Convertidos ----------\n");
            Console.WriteLine("Valor Farenheit : {0:0.00}", n_farenheit);
            Console.WriteLine("Valor Celsius   : {0:0.00}", n_celsius);


            Console.ReadLine();
        }


        public static double converte_farenheit_p_celsius(double n1)
        {
            return(((n1-32)*5)/ 9);

        }
    }
}
