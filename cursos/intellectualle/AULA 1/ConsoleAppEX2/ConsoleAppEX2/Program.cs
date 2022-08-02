using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desenvolvedor:Vinicius Veras
   Data: 28/08/2015
   Objetivo:  Converter uma temperatura de Graus Celsius para Farenheit*/


namespace ConsoleAppEX2
{
    class Program
    {
        static void Main(string[] args)
        {
            // variáveis

            double numero_farenheit = 0, numero_celsius = 0;
            int controle = 0;

            Console.WriteLine("Convesor de Temperaturas ---  Celsius para  Farenheit");

            do
            {
                try
                {
                    Console.WriteLine("\nDigite o número a ser convertido: ");
                    numero_celsius = double.Parse(Console.ReadLine());
                    controle = 1;
                }
                catch (Exception erro)
                {
                    Console.WriteLine("ERRO !! Verifique o valor digitado.");
                    Console.WriteLine("{0}", erro);
                }
            } while (controle != 1);


            // ----------------- chamando função -------------------
            numero_farenheit = converte_celsius_p_farenheit(numero_celsius);

            // -------------------- exibição -------------------------
            Console.WriteLine("Farenheit: {0:0.00}", numero_farenheit);
            Console.WriteLine("Celsius  : {0:0.00}", numero_celsius);


            Console.ReadLine();
        }


       /* Função: converte_converte_celsius_p_farenheit
          Objetivo: Converter graus celius para farenheit
          Paramêtros: double n1
          Retorno: double*/


        public static double converte_celsius_p_farenheit(double n1)
        {
           
             return(((9 * n1) + 160)/5);

        }


    }
}
