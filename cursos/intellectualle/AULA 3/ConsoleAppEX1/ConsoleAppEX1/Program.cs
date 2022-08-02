using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Desenvolvedor: Vinicius Veras 
  Data: 02/09/2015
  Objetivo: 1. Escreva um programa que calcule o salário semanal de um trabalhador. As entradas são o número de horas 
trabalhadas na semana e o valor da hora. Até 40 h/semana não se acrescenta nenhum adicional. 
Acima de 40h e até 60h há um bônus de 50% para essas horas. Acima de 60h há um bônus de 100% para essas horas.
*/

namespace ConsoleAppEX1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero_horas = 0, adicional = 0, controle = 0;
            decimal valor_hora = 0, salario = 0, valor_acrescimo =0;

            do
            {
                try
                {
                    Console.WriteLine("\nDigite o número de horas trabalhadas: ");
                    numero_horas = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite o valor da hora: ");
                    valor_hora = decimal.Parse(Console.ReadLine());

                    if ((numero_horas < 0) || (valor_hora < 0))
                    {
                        Console.WriteLine("\nErro !! Verifique os números de Entradas.\n");
                        controle = 0;
                    }

                    controle = 1;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nErro !! Verifique os números de Entrada.\n");
                }

            } while (controle != 1);

            if (numero_horas >= 40 && numero_horas <= 60)
                   {
                     adicional = 50;
                }
                else
                    if(numero_horas > 60)
                 {
                     adicional = 100;
                 }

              salario = calcula_salario(numero_horas, valor_hora);
              valor_acrescimo = calcula_acrescimo(salario, adicional);


            Console.WriteLine("------------- Folha de Pagamento ------------");
            Console.WriteLine("Número de Horas:    {0:00}", numero_horas);
            Console.WriteLine("Valor Hora:     {0:C2}", valor_hora);
            Console.WriteLine("Adicional:       {0}%", adicional);
            Console.WriteLine("SubTotal:       {0:C2}", salario);
            Console.WriteLine("Salário Total:  {0:C2}", salario + valor_acrescimo);
            Console.ReadLine();

        }

        public static decimal calcula_salario (int n1, decimal n2)
        {
            return (n1 * n2);
        }

        public static decimal calcula_acrescimo(decimal n1, decimal n2)
        {
            return((n1 * n2)/100);
        }

    }
}
