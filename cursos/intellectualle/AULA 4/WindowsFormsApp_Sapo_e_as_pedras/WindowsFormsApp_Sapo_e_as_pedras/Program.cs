using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Exercício Sapo e as pedras
   Desenvolvedor : Vinicius Veras
   Data:26/09/2015
   objetivo:
   Em uma terra distante existe um belo riacho em uma bela vila. N Pedras estão alinhadas em linha reta do número 1 até N, da margem esquerda à margem direita, como mostrado abaixo.
[Flanco esquerdo] - [Pedra 1] - [Pedra 2] - [Pedra 2] - [Pedra 3] - [Pedra 4] - [Pedra N] - [Flanco Direito]
A distância entre duas Pedras adjacentes é exatamente 1 metro, enquanto a distância entre a margem esquerda e a Pedra 1 e a distância entre a Pedra N e a margem direita também são 1 metro.
O sapo Frank está prestes a atravessar o riacho, seu vizinho, o sapo Funny veio a ele e disse:
'Olá Frank, feliz dia das Crianças! Eu tenho um presente para você. 
Vê? Um pequeno pacote na Pedra 5.' 
'Oh, que legal! Obrigado! Eu vou pegar.'
'Espere! Este presente é apenas para sapos inteligentes. Você não pode pegar pulando direto.'
'Oh? Então o que devo fazer?'
'Pular mais vezes. Seu primeiro pulo deve ser da margem esquerda para a Pedra 1, então, pule quantas vezes quiser - não importa se for pra frente ou para traz - mas seu pulo i deve cobrir 2 × i - 1 metros. E mais, uma vez que alcance a margem direita ou esquerda, o jogo termina, sem mais pulos!'
'Hummmm, nada fácil... deixa eu pensar!' Respondeu sapo Frank, 'Devo tentar?'
Entrada
Cada caso de teste contém um única linha. Ela contém dois positivos inteiros N(2 ≤ N ≤ 100), e M(2 ≤ M ≤ N), M indica o número da pedra em que o presente está. O caso de teste no qual N = 0, M = 0 terminará a entrada e não deve ser contado como caso de teste.*/

 
namespace WindowsFormsApp_Sapo_e_as_pedras
{
    class Program
    {
        // variáveis Globais

        public static int ac_pulos = 0, o = 0, verificador = 0, presente = 0;

        static void Main(string[] args)
        {
            // variáveis da Main 

            int quantidade_pedras = 0, pulos = 0, j = 1;

            int distancia = 0;

            // captando dados de entrada
            entrada(ref quantidade_pedras);

            int[] pedras = new int[quantidade_pedras];

            distancia = quantidade_pedras;


            calcula_pulos_direitos(ref pulos, ref j, ref pedras, ref quantidade_pedras, ref distancia);



            Console.ReadKey();

        }


        /*Função: Entrada
          Objetivo: Receber dados de Entrada
          Parâmetros: ref int quantidade_pedras
          return void */


        public static void entrada(ref int quantidade_pedras)
        {
            do
            {
                try
                {
                    Console.WriteLine("Quantidade de Pedras: ");
                    quantidade_pedras = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pedra contendo o Presente: ");
                    presente = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro !! Verifique dados de entrada\n");

                }

                if (presente > quantidade_pedras)
                {


                    Console.WriteLine("Erro!! Verifique dados de entrada\n");
                }

                if ((quantidade_pedras < 2) || (quantidade_pedras > 100))
                {
                    Console.WriteLine("Entre com valores entre 2 a 100\n");
                }

            } while (presente > quantidade_pedras || quantidade_pedras < 2 || quantidade_pedras > 100);


            return;
        }


        /*Função: Calcula_pulos_direitos
         Objetivo: calcular pulos direitos
         Parâmetros: ref int pulos, ref int j, ref int [] pedras, ref int quantidade_pedras, ref int distancia
         return void */


        public static void calcula_pulos_direitos(ref int pulos, ref int j, ref int[] pedras,  ref int quantidade_pedras, ref int distancia)
        {
            int comparativo;

            pedras[presente - 1] = 1;

            if (j == 1)
            {
                pulos = (2 * j) - 1;


                // chamada de função para executar pulos direitos

                executa_pulos_direitos(ref pulos, ref pedras, ref j, ref quantidade_pedras, ref distancia);


            }
            else
            {
                pulos = (2 * j) - 1;


                comparativo = distancia - pulos;

                if (comparativo < 0)
                {

                    // chamada de função para executar pulos esquerdos

                    calcula_pulos_esquerdos(ref j, ref pulos, ref comparativo, ref quantidade_pedras, ref distancia, ref pedras);

                }
                else
                {

                    executa_pulos_direitos(ref pulos, ref pedras, ref j, ref quantidade_pedras, ref distancia);
                }
            }

            return;

        }



        /*Função: Executa_pulos_direitos
         Objetivo: executar pulos direitos
         Parâmetros: ref int pulos, ref int j, ref int [] pedras, ref int quantidade_pedras, ref int distancia
         return void */

        public static void executa_pulos_direitos(ref int pulos, ref int[] pedras,  ref int j, ref int quantidades_pedras, ref int distancia)
        {
            int l = 0;

            // l = 1;

          

            Console.WriteLine("\n\n------------Pulo {0} -----------------\n", j);

            // executando pulos

            while (l != pulos)
            {


                Console.WriteLine("Pedra[{0}] {1} ", o + 1, pedras[o]);
                distancia--;
                l++;
                o++;
            }

            if (pedras[o-1] == 1)
            {
                Console.WriteLine("\nConsegui, mto fácil !!");
                Environment.Exit(0);

            }
            Console.ReadKey();


            j++;

            calcula_pulos_direitos(ref pulos, ref j, ref pedras, ref quantidades_pedras, ref distancia);

            return;
        }



        /*Função: Calcula_pulos_esquerdos
         Objetivo: calcular pulos esquerdos
         Parâmetros: ref int pulos, ref int j, ref int quantidade_pedras, ref int distancia, ref int [] pedras
         return void */


        public static void calcula_pulos_esquerdos(ref int j, ref int pulos, ref int comparativo, ref int quantidade_pedras, ref int distancia, ref int[] pedras)
        {
            int distancia_esquerda = 0;

            pedras[presente] = 1;


            pulos = (2 * j) - 1;

            // calculando as distancias disponiveis para pulos

            distancia_esquerda = (quantidade_pedras - distancia) - 1;

            comparativo = distancia_esquerda - pulos;


            // chamando funcão com base no resultado das distancias

            if (comparativo < 0)
            {
                verificador = 1;
                executa_pulos_esquerdos(ref pedras, ref pulos, ref j, ref distancia_esquerda, ref quantidade_pedras, ref comparativo, ref distancia);
            }
            else
            {
                executa_pulos_esquerdos(ref pedras, ref pulos, ref j, ref distancia_esquerda, ref quantidade_pedras, ref comparativo, ref distancia);

            }

            return;

        }


        /*Função: Executa_pulos_esquerdos 
         Objetivo: Executar pulos esquerdos
         Parâmetros:  ref int [] pedras, ref int pulos, ref int j, ref int distancia_esquerda,  ref int quantidade_pedras, ref int comparativo,  ref int distancia
         return void */

        public static void executa_pulos_esquerdos(ref int[] pedras, ref int pulos, ref int j, ref int distancia_esquerda, ref int quantidade_pedras, ref int comparativo, ref int distancia)
        {

            if (verificador == 0)
            {
                int l = 0;


                Console.WriteLine("\n\n------------Pulo {0} -----------------\n", j);

                // executando pulos

                while (l != pulos)
                {
                    pedras[presente] = 1;

                    Console.WriteLine("Pedra[{0}] {1} ", o - 1, pedras[o - 1]);
                    distancia_esquerda--;
                    distancia++;
                    l++;
                    o--;
                }

               if( pedras[o] == 1)
                {
                    Console.WriteLine("Consegui, mto fácil !!");
                    Console.ReadKey();
                    Environment.Exit(0);

                }

                distancia++;

                Console.ReadKey();


                j++;

                calcula_pulos_esquerdos(ref j, ref pulos, ref comparativo, ref quantidade_pedras, ref distancia, ref pedras);

                return;
            }
            else
            {

                // chamada para função que verifica disponibilidade de pulos para direita
                pedras[presente] = 1;
                verificador_dpossivel_pulo(ref pulos, ref j, ref pedras, ref quantidade_pedras, ref distancia);
            }
        }


        /*Função: Verificador_d_possivel_pulo
     Objetivo: Verificar se é possível pular para à direita, em vista que não do lado esquerdo não dá para pular
     Parâmetros: ref int pulos, ref int j, ref int [] pedras, ref int quantidade_pedras, ref int distancia
     return void */

        public static void verificador_dpossivel_pulo(ref int pulos, ref int j, ref int[] pedras, ref int quantidade_pedras, ref int distancia)
        {

            int comparativo = 0, distancia_direito = 0;

            distancia_direito = quantidade_pedras - o;
            comparativo = distancia_direito - pulos;

            // caso ainda tenha possibilidade de pulos para direita, irá chamar a função do lado citado 
            if (comparativo < 0)
            {
                Console.WriteLine("É Impossível !!!");
            }
            else
            {
           
                calcula_pulos_direitos(ref pulos, ref j, ref pedras, ref quantidade_pedras, ref distancia);
            }

        }
    }
}
        






