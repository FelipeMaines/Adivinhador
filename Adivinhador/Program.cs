using System.Xml;

namespace Adivinhador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            byte contador = 0;
            byte tentativas = 0;
            int numeroMaquina = random.Next(0, 100);
            int pontuacao = 1000;
            int dificuldade = 10;
           
            while (dificuldade != 0 && dificuldade != 1 && dificuldade != 2)
            {

                Console.WriteLine("************************************************************");
                Console.WriteLine("* Qual a dificuldade : [0] Facil / [1] Medio / [2] Dificil *");
                Console.Write("************************************************************\nEscolha: ");

                dificuldade = int.Parse(Console.ReadLine());


                if (dificuldade == 0)
                {
                    tentativas = 15;
                }

                else if (dificuldade == 1)
                {
                    tentativas = 10;
                }

                else
                {
                    tentativas = 5;
                }

                if (dificuldade != 0 && dificuldade != 1 && dificuldade != 2)
                Console.WriteLine("Escolha um numero VALIDO!");
            }
            

            do
            {
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine($"Tentativa {contador}/{tentativas}");
                Console.WriteLine($"Qual seu {contador} chute: ");
                int chute = int.Parse(Console.ReadLine());

                if (chute == numeroMaquina)
                {
                    Console.WriteLine("Parabens, vc acertou!");

                    Console.WriteLine($"Sua pontuacao ficou em {pontuacao}");
                    break;
                }
                else if(chute < numeroMaquina)
                {
                    Console.WriteLine("Chute um numero MAIOR!");

                    pontuacao -= Math.Abs((chute - numeroMaquina) / 2);
                }
                else if (chute > numeroMaquina)
                {
                    Console.WriteLine("Chute um numero MENOR!");

                    pontuacao -= Math.Abs((chute - numeroMaquina) / 2);
                }

                if (contador >= tentativas)
                {
                    Console.WriteLine("********************************************************************************");
                    Console.WriteLine("Infelizmente voce nao conseguiu acertar, tente com uma dificuldade mais facil!");
                    Console.WriteLine("********************************************************************************");
                }   

                contador++;


            } while (contador <= tentativas);
        }
    }
}