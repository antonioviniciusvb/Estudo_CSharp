using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        static void Main(string[] args)
        {
            int i = 0, j = 0, controle = 0;
            List<decimal> peso_boi = new List<decimal>();
            List<int> id_peso = new List<int>();

            decimal n1 = 0, maior_peso = 0;

            decimal[] nu1 = new decimal [10], max = new decimal[10];

            while (controle == 0)
            {
                

                Console.WriteLine("Digite o peso do {0}º Boi: ", i+1);
                n1 = decimal.Parse(Console.ReadLine());

                if (n1 == 0)
                {
                    break;
                }

                nu1[i] = n1;

                lista_boi.Add(n1);

                i++;

                lista_id.Add(i);

            }

            Console.WriteLine("\n--------Exibição --------");

            foreach(decimal item in lista_boi)
            {
                Console.WriteLine("Id Boi:  {0}", lista_id[j]);
                Console.WriteLine("Peso Boi:{0}", lista_boi[j]);
                
                j++;
            }


            for (i = 0; i < lista_boi.Count; i++)
            {
                max[i] = nu1[i];

            }

            for (i = 0; i < lista_boi.Count; i++)
            {
                if (max[i] > nu1[i + 1])
                {
                    maior_peso = max[i];

                }
            }
            Console.WriteLine("Maior = {0}", maior_peso);


            Console.ReadKey();
        }
    }
}
