using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOKENPO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player1, player2;
            int jogada1, jogada2;
            int continua = 1;
            Console.WriteLine("Informe o seu nome player 1");
            player1 = Console.ReadLine();
            Console.WriteLine("Informe o seu nome player 2");
            player2 = Console.ReadLine();
            while (continua == 1)
            {
                jogada1 = 0;
                jogada2 = 0;
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("1 - Pedra ");
                    Console.WriteLine("2 - Papel ");
                    Console.WriteLine("3 - Tesoura ");
                    Console.WriteLine($"Informe a sua jogada {player1}");
                    jogada1 = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    if (jogada1 >= 4)
                    {
                        Console.WriteLine($"{jogada1} não é uma jogada válida");
                    }
                    else if (jogada1 == 0)
                    {
                        Console.WriteLine($"{jogada1} não é uma jogada válida");
                    }
                    Console.WriteLine($"Informe a sua jogada {player2}");
                    jogada2 = Int32.Parse(Console.ReadLine());
                    if (jogada2 >= 4)
                    {
                        Console.WriteLine($"{jogada2} não é uma jogada válida");
                    }
                    else if (jogada2 == 0)
                    {
                        Console.WriteLine($"{jogada2} não é uma jogada válida");
                    }
                }
                switch (jogada1)
                {
                    case 1:
                        if (jogada1 == 1 && jogada2 == 2)
                        {
                            Console.WriteLine($"{player2} venceu");
                        }
                        else if (jogada1 == 1 && jogada2 == 3)
                        {
                            Console.WriteLine($"{player1} venceu");
                        }
                        else  
                        {
                            Console.WriteLine("Empate");
                        }
                        break;
                    case 2:

                        if (jogada1 == 2 && jogada2 == 1)
                        {
                            Console.WriteLine($"{player1} venceu");

                        }
                        else if (jogada1 == 2 && jogada2 == 3)
                        {
                            Console.WriteLine($"{player2} venceu");
                        }
                        else 
                        {

                            Console.WriteLine("Empate");
                        }
                        break;
                    case 3:
                        if (jogada1 == 3 && jogada2 == 2)
                        {
                            Console.WriteLine($"{player1} venceu");
                        }
                        else if (jogada1 == 3 && jogada2 == 1)
                        {
                            Console.WriteLine($"{player2} venceu");

                        }
                        else 
                        {
                            Console.WriteLine("Empate");
                        }
                        break;
                }
                /* default:
                     Console.WriteLine("Opção inválida");
                     break;*/
                Console.WriteLine("Deseja continuar - 1 para sim, 2 para não");
                continua = Int32.Parse(Console.ReadLine());


            }            
            Console.WriteLine("Fim");
               Console.ReadKey();
        }
    }
}
        