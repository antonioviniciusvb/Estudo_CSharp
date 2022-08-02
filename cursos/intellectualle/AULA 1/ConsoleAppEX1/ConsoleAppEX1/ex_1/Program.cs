using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desenvolvedor : Vinicius Veras 
   Data: 22/08/2015
   Objetivo:
            Calcular a quantidade de litros de combustível gasta em uma viagem utilizando um
            automóvel que faz 12 km por litro.Para o cálculo o usuário deve fornecer o tempo gasto na      
            viagem e a velocidade média.
            O programa deve apresentar os valores de: velocidade média, tempo gasto, distância percorrida
            e a quantidade de litros gastos na viagem.*/



namespace ConsoleAppEX1
{
    class Program
    {
      
          static void Main(string[] args)
        {

            // ----------------------- variáveis -------------------

            double tempo_gasto = 0, velocidade_media = 0, distancia = 0, litros_usados = 0;
            int controle = 0;

    
            // --------------------- capitando dados --------------
            do
            {
                try
                {  // variável tempo_gasto
                    Console.WriteLine("\nDigite o tempo gasto na viagem: ");
                    tempo_gasto = double.Parse(Console.ReadLine());

                    // variável velocidade media
                    Console.WriteLine("Digite a velocidade média da viagem: ");
                    velocidade_media = double.Parse(Console.ReadLine());


                    // atribuindo 1 na variável para sair do lopping
                    controle = 1;
                }
                catch (Exception erro)
                {   
                    // mensagem de erro, caso ocorra alguma exeção no recebimento dos dados
                    Console.WriteLine("ERRO !!\n Verifique os dados inseridos..");
             
                }

            } while (controle != 1);


                // ------------- Chamada de Funções ------------------

               distancia = calcular_distancia(tempo_gasto,velocidade_media);
               litros_usados = calcular_litros_usados(distancia);

            // -------------------    exibição -----------------------


                Console.WriteLine(" ---------- Relatório ---------------");   
                Console.WriteLine("Tempo Gasto     : {0}", tempo_gasto);
                Console.WriteLine("Velocidade Média: {0}", velocidade_media);
                Console.WriteLine("Distância       : {0:0.00}", distancia);
                Console.WriteLine("Litros Usados   : {0}", litros_usados);


                Console.ReadLine();
            
            // -------------------- fim main ----------------------------
        }


        /*Função: calcular_distancia
          Objetivo: Calcular à distancia
          Paramêtros: double n1, double n2 
          Retorno: double*/

        public static double calcular_distancia(double n1, double n2)
        {         
               return (n1 * n2);
        }

        /*Função: calcular_litros_usados 
          Objetivo: Calcular litros usados 
          Paramêtros: double n1
          Retorno: double*/

        public static double calcular_litros_usados(double n1)
        {
            return (n1 / 12);
        }


    }
}
