using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_FormatandoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis 
            int n1 = 5121, n2 = 141, n3 = 14785;
            long n4 = 8499987548;


            // Formatando com zeros à esquerada caso não tenha 5 valores
            Console.WriteLine("----------------Formatando valores---------");
            Console.WriteLine(string.Format("{0:00000}", n1));
            Console.WriteLine(string.Format("{0:00000}", n2));
            Console.WriteLine(string.Format("{0:00000}", n3));
            Console.WriteLine(string.Format("{0:00000}", n4));

            // Formatando à direita caso não tenha 5 valores


            Console.WriteLine(string.Format("\n{0,5}", n1));
            Console.WriteLine(string.Format("{0,5}", n2));
            Console.WriteLine(string.Format("{0,5}", n3));
            Console.WriteLine(string.Format("{0,5}", n4));

            Console.ReadLine();

        }
    }
}
