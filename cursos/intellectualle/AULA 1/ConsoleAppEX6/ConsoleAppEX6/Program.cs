using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Desenvolvedor: Vinicius Veras 
  Data: 28/08/2015
  Objetivo:
    Em uma eleiçao presidencial existem 4 candidatos. Os votos são informados através de códigos
Os dados informados para a contagem dos votos obedecem a seguinte codificação.
1,2,3,4 = voto para os respectivos candidatos

5 = voto nulo
6 = voto em branco

Elabore um algoritmo que leia o código do candidato em um voto.
Calcule e escreva.

 - total de votos para os respectivos candidatos
 - total dos votos nulos
 - total de votos em branco
 
 Como finalizador do conjunto de votos tem-se o valor zero*/




namespace ConsoleAppEX6
{
    class Program
    {
        static void Main(string[] args)
        {

            // variáveis

            int voto = 1, cont_malluf = 0, cont_lula = 0, cont_collor = 0, cont_sarney = 0, cont_nulo = 0, cont_branco = 0, controle = 0;


            Console.WriteLine("--------------  Eleição 2016 -------------------");
            Console.WriteLine("\t\t1.....Malluf \n\t\t2.....Lula\n\t\t3.....Sarney\n\t\t4.....Collor\n\t\t5.....Nulo\n\t\t6.....Branco");


            while (voto != 0)
            {
                do
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("\nTecle no número correspondente à sua escolha: ");
                            voto = int.Parse(Console.ReadLine());
                            controle = 1;
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine("ERRO !! Favor verificar o valor inserido.");
                        }

                    } while (controle != 1);

                    if (voto > 6 || voto < 0)
                        Console.WriteLine("ERRO!! Favor verificar o valor inserido.");

                } while (voto > 6 || voto < 0);

                // somando os votos

                switch (voto)
                {
                    case 1:
                        cont_malluf++;
                        break;

                    case 2:
                        cont_lula++;
                        break;

                    case 3:
                        cont_sarney++;
                        break;
                    case 4:
                        cont_collor++;
                        break;

                    case 5:
                        cont_nulo++;
                        break;

                    case 6:
                        cont_branco++;
                        break;

                    default:
                        controle = 0;
                        break;
                }
            }


            Console.WriteLine("-------- Resultado ----------");
            Console.WriteLine("Malluf = {0}", cont_malluf);
            Console.WriteLine("LULA   = {0}", cont_lula);
            Console.WriteLine("Sarney = {0}", cont_sarney);
            Console.WriteLine("Collor = {0}", cont_collor);
            Console.WriteLine("Nulo   = {0}", cont_nulo);
            Console.WriteLine("Branco = {0}", cont_branco);

            Console.ReadLine();

        }
    }
}
