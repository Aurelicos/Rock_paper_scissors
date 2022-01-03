using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamen_Nuzky_Papir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\nDo you want to play Rock, paper, scissors? (yes/no) ");

            int ComputerWons = 0;
            int PlayerWons = 0;

            string answer = Console.ReadLine();

            Console.WriteLine("\nEnter number of rounds: ");

            int rounds = int.Parse(Console.ReadLine());
            for (int i = 0; i < rounds; i++)
            {
                Console.Clear();
                Random RandomCislo = new Random();
                int Computer = RandomCislo.Next(1, 4);

                if (answer == "yes")
                {
                    Console.WriteLine("\nEnter 1 for rock");
                    Console.WriteLine("\nEnter 2 for scissors");
                    Console.WriteLine("\nEnter 3 for paper");
                    int input = int.Parse(Console.ReadLine());

                    if (Computer == input)
                    {
                        Console.Clear();
                        PlayerWons++;
                        ComputerWons++;
                        Console.WriteLine("\nThis round ended in a draw.");
                    }
                    else if (Computer == 1 && input == 2)
                    {
                        Console.Clear();
                        ComputerWons++;
                        Console.WriteLine("\nThis round was won by a computer because he chose the stone.");
                    }
                    else if (Computer == 2 && input == 1)
                    {
                        Console.Clear();
                        PlayerWons++;
                        Console.WriteLine("\nYou won this round because the computer chose scissors.");
                    }
                    else if (Computer == 1 && input == 3)
                    {
                        Console.Clear();
                        PlayerWons++;
                        Console.WriteLine("\nYou won this round because the computer chose the stone.");
                    }
                    else if (Computer == 3 && input == 1)
                    {
                        Console.Clear();
                        ComputerWons++;
                        Console.WriteLine("\nThe computer won this round because he chose paper.");
                    }
                    else if (Computer == 2 && input == 3)
                    {
                        Console.Clear();
                        ComputerWons++;
                        Console.WriteLine("\nThe computer won this round because he chose the scissors.");
                    }
                    else if (Computer == 3 & input == 2)
                    {
                        Console.Clear();
                        PlayerWons++;
                        Console.WriteLine("\nYou won this round because the computer chose paper.");
                    }



                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                }
                else
                {
                    Environment.Exit(0);
                }

            }

            if (PlayerWons > ComputerWons)
            {
                Console.Clear();
                Console.WriteLine("\nThe player won.");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nThe computer won.");
                Console.ReadKey();
            }

            if (PlayerWons == ComputerWons)
            {
                Console.Clear();
                Console.WriteLine("\nYou both won.");
                Console.ReadKey();
            }
        }
    }
}