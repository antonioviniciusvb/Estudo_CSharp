using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // usar arraylist

/* Desenvolvedor: Vinicius Veras 
   Data: 03/09/2015
   Objetivo: 
   Um pecuarista possui uma determinada quantia de bois, que possuem um identificador numérico (de 1 a n) 
cada um. Faça um programa que:

a. receba o peso de cada boi, um por vez, e o armazene em um vetor. Se o peso digitado for 0 significa que não 
há mais bois a serem digitados;

b. mostre a lista de todos os bois com seus identificadores e também os identificadores do boi mais gordo e do boi 
mais magro. Se houver dois ou mais bois mais gordos ou mais magros mostrar o de menor identificador;

c. Faça o mesmo programa considerando que o número de bois é fixo e igual a dez.*/

namespace ConsoleAppEX_2
{
    class Program
    {
        public struct boi
        {
            public decimal peso_boi;
            public int id_boi;
        }

        static void Main(string[] args)
        {
            int i = 0, j = 0, k = 1, controle = 0;
            const int MAX = 10;

            boi[] dados_boi = new boi[MAX];



            decimal n1 = 0, maior_peso = 0, menor_peso = 999999;
            int id_maior_peso = 0, id_menor_peso = 0;


            while (controle == 0)
            {


                Console.WriteLine("Digite o peso do {0}º Boi: ", i + 1);

                n1 = decimal.Parse(Console.ReadLine());

                if (n1 == 0)
                {
                    break;
                }

                dados_boi[i].peso_boi = n1;
                dados_boi[i].id_boi = i;

                i++;
                j = i;

            }

            Console.WriteLine("\n--------Exibição --------");

            for (i = 0; i < j; i++)
            {
                Console.WriteLine("\nBoi ID:  {0:00}", dados_boi[i].id_boi+1);
                Console.WriteLine("Peso Boi:{0:00.0} Kg", dados_boi[i].peso_boi);

             
            }


            for (i = 0; i < j; i++)
            {
                if (dados_boi[i].peso_boi > maior_peso)
                {
                    
                    maior_peso = dados_boi[i].peso_boi;
                    id_maior_peso = dados_boi[i].id_boi+1;
                }
            }

            for(i = 0; i < j; i++)
            {
                if (dados_boi[i].peso_boi < menor_peso)
                {

                    menor_peso = dados_boi[i].peso_boi;
                    id_menor_peso = dados_boi[i].id_boi + 1;
                }
            }

            Console.WriteLine("------------ Dados Complementares ---------");
            Console.WriteLine("\nMaior Peso = {0:00}g\nid_boi: {1}", maior_peso, id_maior_peso);
            Console.WriteLine("\nMenor Peso = {0:00.0} Kg\nid_boi: {1}", menor_peso, id_menor_peso);
            Console.ReadKey();
      }

    }
}

   