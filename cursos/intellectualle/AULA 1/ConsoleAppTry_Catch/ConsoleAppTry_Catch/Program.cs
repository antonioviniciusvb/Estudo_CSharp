using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTry_Catch
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variáveis
            int n1 = 0, n2 = 0, resultado, i;

            // capitando os valores
            try
            {
                
                    Console.WriteLine("Digite o {0} valor: ",i+1);
                    n1 = int.Parse(Console.ReadLine());
               

                Console.WriteLine("Digite o 2º valor: ");
                n2 = int.Parse(Console.ReadLine());

                resultado = n1 / n2;

                Console.WriteLine("O Resultado = {0}", resultado);

            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine("{0}", erro);
            }
            catch(Exception erro)
            {
                Console.WriteLine("erro !!!");
            }
            Console.ReadLine();
        }
    }
 }