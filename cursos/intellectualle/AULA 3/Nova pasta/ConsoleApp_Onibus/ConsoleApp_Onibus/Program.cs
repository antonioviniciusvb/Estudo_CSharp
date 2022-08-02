using System;

/* Desenvolvedor: Vinicius Veras
 * DATA: 12/09/2015
 * Objetivo:
 *  Uma empresa possui ônibus com 48 lugares (24 nas janelas e 24 no corredor).
    Faça um programa para controlar as poltronas ocupadas no corredor e na janela.
    Considere que 0 representa poltrona desocupada e 1, poltrona ocupada.
    Inicialmente, todas as poltronas estarão livres. Depois disso, o programa deverá
    apresentar as seguintes opções:
     Vender passagem
     Mostrar mapa de ocupação do ônibus
     Encerrar
        Quando a opção escolhida for Vender Passagem, deverá ser perguntado se o usuário
        deseja janela ou corredor e o número da poltrona. O programa deverá, então, dar uma
        das seguintes mensagens:
             Venda efetivada – se a poltrona solicitada estiver livre, marcando-a como
            ocupada.
             Poltrona ocupada – se a poltrona solicitada não estiver disponível para venda
             Ônibus lotado – quando todas as poltronas já estiverem ocupadas.*/

namespace ConsoleApp_Onibus
{
    class Program
    {
        // Variáveis Globais
        private static int[] p_janela = new int[MAX], p_corredor = new int[MAX];
        private static int controle = 0;
        private const int MAX = 2;

        //----- Íncio da Main 
        static void Main(string[] args)
        {

            // Variáveis da Main
            int opcao = 0, opcao2 = 0;
           
            // chamada de função de entrada de dados 
            entrada(ref opcao);

            Console.Title = "Controle de Poltronas";// Titulo do Programa


            // do while encarregado de executar as funções conforme opção do usuário
            do
            {
                if (opcao == 3)
                {
                    break;
                }
                switch (opcao)
                {

                    case 1:
                        poltronas_disponiveis(ref opcao2);
                        break;

                    case 2:

                        mostra_mapa_ocupacional();
                        break;

                    default: 
                            Console.WriteLine("ERRO !! Verifique Dados de entrada.");
                        break;
                }

                entrada(ref opcao);

            } while (opcao != 3);

            

   
            Console.ReadLine();
        }

        /* Função: entrada
           Objetivo: receber dado de entrada
           Parâmetro: ref int opcao
           return void*/

        public static void entrada(ref int opcao)
        {
            Console.Clear();
            
            opcao = 0;

            Console.WriteLine("\n\n1 - Vender Passagem\n2 - Mostrar mapa de Ocupação de Ônibus\n3 - Encerrar\n\t\t Escolha sua Opção: ");
            opcao = int.Parse(Console.ReadLine());
            return;
        }

        /* Função: poltronas_disponiveis
         Objetivo: receber dados das poltronas e fazer uma verificação com outros métodos para mostrar poltronas disponivéis
         Parâmetro: ref int opcao2
         return void*/

        public static void poltronas_disponiveis(ref int opcao2)
        {
            int poltrona = 0;

            if (controle != 0)
            {
               
                    
                mostra_mapa_ocupacional();
            
                Console.WriteLine("\n\n1 - Janela\n2 - Corredor\nDigite a opção desejada: ");
                opcao2 = int.Parse(Console.ReadLine());
            }
            else
            {  
                Console.WriteLine("\nTodos os lugares estão Livres !!");
                Console.WriteLine("\n\n1 - Janela\n2 - Corredor\nDigite a opção desejada: ");
                opcao2 = int.Parse(Console.ReadLine());
            }

                Console.WriteLine("\nEscolha uma Poltrona disponivel: ");
                poltrona = int.Parse(Console.ReadLine());

            controle++;
            verificar_e_reservar_passagem(ref opcao2, poltrona);
            return;
       }


        /* Função: verificar_e_reservar_passagem
       Objetivo: reservar passagem para o usuario
       Parâmetro: ref int opcao, int poltrona
       return void*/

        public static void verificar_e_reservar_passagem(ref int opcao2, int poltrona)
        {
            int i = 0, c_1 = 0, c_2 = 0;

            for (i = 0; i < MAX; i++)
            {
                if (p_janela[i] == 1)
                {
                    c_1++;
                }
                if (p_corredor[i] == 1)
                {
                    c_2++;
                }
            }

            if (c_1 == MAX && c_2 == MAX)
            {
                Console.WriteLine("\nÔnibus lotado!!");
            }
            else
            {
                switch (opcao2)
                {
                    case 1:
                        if (p_janela[poltrona - 1] == 0)
                        {
                             p_janela[poltrona - 1] = 1;
                             Console.WriteLine("\nVenda Efetivada!!");
                        }
                         else
                             {
                                  Console.WriteLine("\nPoltrona Ocupada!!");
                              }

                        break;

                            case 2:

                             if (p_corredor[poltrona - 1] == 0)
                                 {
                                    p_corredor[poltrona - 1] = 1;

                                    Console.WriteLine("Venda Efetivada!!");
                                 }
                                  else
                                     {
                                         Console.WriteLine("\nPoltrona Ocupada!!");
                                     }
                      break;

                            default:

                        Console.WriteLine("\nErro !!");

                        break;
                  }
            }

            Console.ReadKey();
        }
           

        

        /* Função: mostra_mapa_ocupacional
  Objetivo: mostrar o mapa ocupacional 
  Parâmetro: void
  return void*/

        public static void mostra_mapa_ocupacional()
        {
            int i = 0;

            Console.WriteLine("------------- Janela -----------------------\n");

            
                for (i = 0; i < p_janela.Length; i++)
                {
                    if (p_janela[i] == 0)
                    {
                        Console.WriteLine("{0} - Livre", i+1);
                    }
                    else
                    {
                        Console.WriteLine("{0} - Ocupado", i+1);
                    }
                }

                Console.WriteLine("\n\n----------- Corredor -----------------\n");

                for (i = 0; i < p_corredor.Length; i++)
                {
                    if (p_corredor[i] == 0)
                    {
                        Console.WriteLine("{0} - Livre", i + 1);
                    }
                    else
                    {
                        Console.WriteLine("{0} - Ocupado", i + 1);
                    }
                }

            Console.ReadKey();
            }
        }
     }


;