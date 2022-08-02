using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Desenvolvedor: Vinicius Veras 
 Data: 16/09/2015
 Objetivo: Fazer um programa para:

a. receber 3 notas parciais do aluno em um vetor e a nota do exame em uma variável separada (-1 se o aluno não fez exame).

b. chamar a função SITUACAO, com as seguintes características:

i. Parâmetros: vetor de notas parciais e nota do exame

ii. Retorno: 0 se o aluno está reprovado direto, 1 se o aluno está reprovado em exame, 2 se o aluno está aprovado em exame e 3 se ele está aprovado direto. */


namespace ConsoleApp_ex_6
{
    class Program
    {

        public static int retorno;

        static void Main(string[] args)
        {
            decimal[] nota_parciais = new decimal[3];
            decimal nota_do_exame = 0, media_final = 0;

            entrada_de_dados(ref nota_parciais, ref nota_do_exame);
            situacao(nota_parciais, ref nota_do_exame, ref media_final);
            exibição(ref nota_parciais, ref nota_do_exame, ref media_final);

            Console.ReadKey();
        }



        public static void entrada_de_dados(ref decimal[] nota_parciais, ref decimal nota_do_exame)
        {
            int i = 0;

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite {0}º Nota do Aluno:", i + 1);
                nota_parciais[i] = decimal.Parse(Console.ReadLine());

            }

            Console.WriteLine("\nObs:Nota -1, caso o aluno não tenha feito o exame.");
            Console.WriteLine("Digite Nota do Exame: ");
            nota_do_exame = decimal.Parse(Console.ReadLine());

        }




        private static void exibição(ref decimal[] nota_parciais, ref decimal nota_do_exame, ref decimal media_final)
        {
            int i = 0;

            Console.WriteLine("\n------------- Exibição -------------\n");

            foreach (decimal item in nota_parciais)
            {
                Console.WriteLine("{0}º Nota Parcial = {1:00.00}", i + 1, item);
                i++;
            }

            Console.WriteLine("Nota Exame = {0:00.00}", nota_do_exame);
            Console.WriteLine("Média Final = {0:00.00}", media_final);

            switch (retorno)
            {
                case 0:
                    Console.WriteLine("\nAluno Reprovado !!");
                    break;

                case 1:
                    Console.WriteLine("\nAluno Reprovado em Exame !!");
                    break;

                case 2:
                    Console.WriteLine("\nAluno Aprovado em Exame !!");
                    break;

                case 3:
                    Console.WriteLine("\nAluno Aprovado Direto !!");
                    break;

                default:

                    Console.WriteLine("\nErro !!");
                    break;
            }
        }


        private static void situacao(decimal[] nota_parciais, ref decimal nota_do_exame, ref decimal media_final)
        {
            if (nota_do_exame == -1)
            {
                nota_do_exame = 0;
            }

            media_final = (nota_parciais[0] + nota_parciais[1] + nota_parciais[2] + nota_do_exame) / 3;

            if (media_final > 70)
            {
                retorno = 3;
            }
            else
            {
                if (nota_do_exame < 30 || media_final < 30)
                {
                    retorno = 0;

                }
                else
                    if (nota_do_exame > 30 && nota_do_exame < 50)
                {
                    retorno = 1;

                }
                else
                    if (nota_do_exame >= 60 && nota_do_exame < 80)
                {
                    retorno = 2;

                }
            }


        }
    }
}