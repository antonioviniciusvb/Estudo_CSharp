using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Desenvolvedor: Vinicius Veras
  Data: 08/09/2015
  Objetivo: 
     Um cinema que possui capacidade de 20 lugares está sempre lotado. Certo dia cada espectador respondeu a um questionário,
onde constava:

- sua idade;

- sua opinião em relação ao filme, que podia ser: ótimo, bom, regular, ruim ou péssimo.


Elabore um programa que, recebendo estes dados calcule e mostre:

a. a quantidade de respostas ótimo;

b. a diferença percentual entre respostas bom e regular;

c. a média de idade das pessoas que responderam ruim;

d. a porcentagem de respostas péssimo e a maior idade que utilizou esta opção;

e. a diferença de idade entre a maior idade que respondeu ótimo e a maior idade que respondeu ruim.
*/



namespace ConsoleAppEX_3
{
    class Program
    {
        // ------------------------ struct global ----------------------------------
         
        public struct usuarios
        {
            public string nome;
            public int idade;
            public int opiniao;

        }


        static void Main(string[] args)
        {

            // ------------------------------- Variáveis da Main ---------------------------

            int i = 0, j = 0, k = 0, l = 0, m = 0, n = 0, i_pessimo = 0, lugares = 5, i_otimo = 0, i_bom = 0;
            int i_regular = 0, i_ruim = 0, ac_usuarios_idade_ruim = 0, media_usuarios_opiniao_ruim = 0;
            int percentual_otimo = 0, percentual_bom = 0, percentual_regular = 0, percentual_ruim = 0, percentual_pessimo = 0;
            int diferença_percentual = 0, maior_idade_pessimo = 0;

            usuarios[] dados_usuarios = new usuarios[lugares];


            // ------------------------------ recebendo dados ---------------------------------------
            Console.WriteLine(" --------- Questíonario de Satisfação -------\n\t\t 1- Ótimo\n\t\t 2-bom\n\t\t 3 - Regular \n\t\t 4- Ruim\n\t\t 5 - Péssimo");

            for (i = 0; i < lugares; i++)
            {
                Console.WriteLine("\nInsira seu nome: ");
                dados_usuarios[i].nome = Console.ReadLine();

                Console.WriteLine("\nInsira sua idade: ");
                dados_usuarios[i].idade = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite sua opinião: ");
                dados_usuarios[i].opiniao = int.Parse(Console.ReadLine());

                
                if (dados_usuarios[i].opiniao == 1)
                {
                    j++;
                    i_otimo = contador_opinioes(j);

                }
                else
                if (dados_usuarios[i].opiniao == 2)
                {
                    k++;
                    i_bom = contador_opinioes(k);

                }
                else
                if (dados_usuarios[i].opiniao == 3)
                {
                    l++;
                    i_regular = contador_opinioes(l);
                }
                else
                if (dados_usuarios[i].opiniao == 4)
                {
                    m++;
                    ac_usuarios_idade_ruim = ac_usuarios_idade_ruim + dados_usuarios[i].idade;
                    i_ruim = contador_opinioes(m);

                   
                }
                else
                    if (dados_usuarios[i].opiniao == 5)
                {
                    n++;
                    i_pessimo = contador_opinioes(n);
                }
            }

            // -------------------------- chamada de funções ------------------------------------

            if (m != 0)
            {
                media_usuarios_opiniao_ruim = calcula_media_usuarios(m, ac_usuarios_idade_ruim);
            }
            else
            {
                media_usuarios_opiniao_ruim = 0;
            }

            percentual_otimo = calcula_percentual_opinioes(j, lugares);
            percentual_bom = calcula_percentual_opinioes(k, lugares);
            percentual_regular = calcula_percentual_opinioes(l, lugares);
            percentual_ruim = calcula_percentual_opinioes(m, lugares);
            percentual_pessimo = calcula_percentual_opinioes(n, lugares);

            diferença_percentual = calcula_diferença_percentual(percentual_bom, percentual_ruim);
            maior_idade_pessimo = busca_maior_valor(dados_usuarios, lugares);

            exibicao(dados_usuarios,lugares,i_otimo,i_bom,i_regular,i_ruim,i_pessimo,percentual_otimo,percentual_bom,percentual_regular,percentual_ruim,percentual_pessimo,diferença_percentual,maior_idade_pessimo);



            Console.WriteLine("Digite qualquer tecla para encerrar");
            Console.Read();
        }


        public static int contador_opinioes(int n1)
        {
            int ac = 0;
            return (ac = ac + n1);
        }


        public static int calcula_media_usuarios(int n1, int n2)
        {
            int resultado = 0;
            return (resultado = n2 / n1);
        }

        public static int calcula_percentual_opinioes(int n1, int n2)
        {
            int p = 0, g = 0;

            p = n1 * 100;
            return (g = p / n2);
        }

        public static int calcula_diferença_percentual(int n1, int n2)
        {
            int diferenca = 0;

            if (n1 > n2 || n1 == n2)
            { 
               return (diferenca = n1 - n2);
            }
             else
	            {
                    return (diferenca = n2 - n1);
                }
        }

        public static int busca_maior_valor(usuarios [] dados_usuarios, int n1)
            {
                int maior = 0, i = 0;
                    
                for(i = 0; i < n1; i++)
                {
                  if (dados_usuarios[i].opiniao == 5)
                    {
                        if (dados_usuarios[i].idade > maior)
                         {
                             maior = dados_usuarios[i].idade;
                         }
                    }
                }

                 return (maior);
            }

        public static void exibicao(usuarios [] dados_usuarios,int lu, int c_o, int c_b, int c_re, int c_ru, int c_p, int p_o, int p_b, int p_re, int p_ru, int p_p, int d_p, int m_p)
        {

            int i = 0;

            for(i = 0; i < lu; i++)
            {
                Console.WriteLine("Usuario {0}\nNome = {1}",i+1, dados_usuarios[i].nome);
                Console.WriteLine("Idade = {0}", dados_usuarios[i].idade);
                Console.WriteLine("Opinião = {0}\n", dados_usuarios[i].opiniao);

            }



            Console.WriteLine("--------- Opiniões -----------");
            Console.WriteLine("Ótimo   = {0:00}", c_o);
            Console.WriteLine("Bom     = {0:00}", c_b);
            Console.WriteLine("Regular = {0:00}", c_re);
            Console.WriteLine("Ruim    = {0:00}", c_ru);
            Console.WriteLine("Péssimo = {0:00}", c_p);
            Console.WriteLine("\n------- Percentual ---------- ");
            Console.WriteLine("ótimo   = {0:00}%", p_o);
            Console.WriteLine("Bom     = {0:00}%", p_b);
            Console.WriteLine("Regular = {0:00}%", p_re);
            Console.WriteLine("Ruim    = {0:00}%", p_ru);
            Console.WriteLine("Péssimo = {0:00}%", p_p);
            Console.WriteLine("--Diferença Percentual entre Ótimo e Ruim\n\t\t{0:00}%", d_p);
            Console.WriteLine("\n--Maior idade com Opiniao Péssimo:\n\t\t{0:00}", m_p);

        }
    }

  
}
    


