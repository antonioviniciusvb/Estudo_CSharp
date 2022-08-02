using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp_Calculadora_2valores_entrada
{
    class Program
    {
        public static float r, a, b;
        public static string msg = "Tecle algo para continuar...";

        static void Main(string[] args)
        {
            string opcao = "0";

            while (opcao != "5")
            {
                Console.Title = "Calculadora";
                Console.BackgroundColor = ConsoleColor.DarkCyan; // cor do fundo da tela
                Console.ForegroundColor = ConsoleColor.Green; // cor do texto de apresentação
                Console.Clear();

                Console.WriteLine("Menu Principal\n\n\n");
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicção\n4 - Divisão\n5 - Fim do Programa\n");

                opcao = Console.ReadLine();

                if (opcao != "5")
                {
                    switch (opcao)
                    {

                        case "1": rotsoma();
                            break;

                        case "2": rotsubtracao();
                            break;

                        case "3": rotmultiplicacao();
                            break;

                        case "4": rotdivisao();
                            break;

                        default:
                            Console.WriteLine("opcao invalida!!");
                            Console.WriteLine(msg);
                            Console.ReadKey();
                            break;


                    }
                }
            }
        }
                private static void entrada()
                {
                    Console.WriteLine("Entre um valor para A: ");
                    a = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Entre um valor para B: ");
                    b = Convert.ToSingle(Console.ReadLine());
                }
                
                private static void saida()
                {
                    Console.WriteLine();
                    Console.WriteLine("O resultado entre A e B = {0:0.00}\n\n", r);
                    Console.WriteLine(msg);
                    Console.ReadKey();
                }
                
                private static void rotsoma()
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Rotina de Soma\n\n");
                    Console.WriteLine();
                   
                    entrada();
                    r = a + b;
                    saida();
                }
                
                private static void rotsubtracao()
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Rotina de subtração");
                    Console.WriteLine("--------------------\n");
                    entrada();
                    r = a - b;
                    saida();
                }

                private static void rotmultiplicacao()
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Rotina de Multiplicação");
                    Console.WriteLine("---------------------------\n");
                    entrada();

                    r = a*b;
                    saida();
                }

                private static void rotdivisao()
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Rotina de Divisão");
                    Console.WriteLine("------------------------\n");
                    entrada();

                    if(b == 0)
                    {
                        Console.WriteLine("\nerro\n");
                        Console.WriteLine(msg);
                        Console.ReadKey();
                    }
                    else
                    {
                        r = a/b;
                        saida();
                    }
             }
    }
}
