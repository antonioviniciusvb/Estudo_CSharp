using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Desenvolvedor: Vinicius Veras
   Data: 28/08/2015
   Objetivo: 
   Apresentar o valor do volume de um galão (uma lata) de óleo utilizando a fórmula:
   V = 3.1415927 * R * R * H, em que as variáveis V, R e H representam respectivamente o volume
   o raio e a altura do galão. */

 


namespace ConsoleAppEX4
{
    class Program
    {
        static void Main(string[] args)
        {
            // variáveis 
            double volume = 0, raio = 0, altura = 0;
            int controle = 0;

            do
            {
                try
                {
                    Console.WriteLine("\nDigite o raio do galão: ");
                    raio = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a altura do galão: ");
                    altura = double.Parse(Console.ReadLine());
                    controle = 1;
                }
                catch (Exception erro)
                {
                    Console.WriteLine("Erro !!! Verifique o número inserido.");
                }
            } while (controle != 1);

            volume = calcula_volume(raio, altura);

            Console.WriteLine("Volume = {0:0.00}", volume);

            Console.ReadLine();

        }


        public static double calcula_volume(double n1, double n2)
        {
            return((3.1415927*n1) *n1*n2);
        }
    
    }
}
