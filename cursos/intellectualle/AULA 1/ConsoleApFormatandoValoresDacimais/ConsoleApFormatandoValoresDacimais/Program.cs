using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApFormatandoValoresDacimais
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 2031.3, n2 = 214.662451, n3 = 11.10, n4 = 10.5;
            decimal n5 = 2216388235.221553m;
            Console.WriteLine("-------- Valores Formatados ---------------");

            // Mostrando com 2 casa decimais
            Console.WriteLine(string.Format("{0:0.00}", n1));
            Console.WriteLine(string.Format("{0:0.00}", n2));
            Console.WriteLine(string.Format("{0:0.00}", n3));
            Console.WriteLine(string.Format("{0:0.00}", n4));

            // Mostrando com separadopr de milhar
            Console.WriteLine(string.Format("{0:0,0.000}", n1));


            //Mostrando com formato de moeda
            Console.WriteLine("O seu valor é {0:C2}", n5);
            Console.ReadLine();


        }
    }
}
