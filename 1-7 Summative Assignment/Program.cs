using System.Runtime.CompilerServices;

namespace _1_7_Summative_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string instruction;
            bool next = false;

            while (!next)
            {
                Console.WriteLine("Wecome to the ROCK PAPER SCISSORS TOURNAMENT.");
                Console.WriteLine("");
                Console.WriteLine("Type RULES (R) to read rules or type ENTER (E) to start");
                instruction = Console.ReadLine().ToLower();

                if (instruction == "r" || instruction == "rule")
                {
                    Console.WriteLine("Rules");
                    Console.Read();
                }
                else if (instruction == "enter" || instruction == "e")
                {
                    Console.WriteLine("Begin");
                    next = true;
                }
                else
                {
                    Console.WriteLine("Error, press enter to try again.");
                    Console.ReadLine();
                    Console.Clear();

                }
            }

            Random Generator = new Random();

            int botHand, rock = 0, paper = 1, scissors = 2;

            bool done = false;

            string handChoice;

            double money = 50;

            double bet;



            while (!done)
            {

                next = false;

                do
                {
                    Console.WriteLine("You have " + money);
                    Console.WriteLine("How much are you betting");
                    double.TryParse(Console.ReadLine(), out bet);

                    if (bet > money)
                    {
                        Console.WriteLine("You do not have enough money to be that amount. Please try again.");
                    }
                    else if (bet <= money)
                    {
                        Console.WriteLine("You are betting " + bet.ToString("C") + " good luck.");


                        next = true;
                    }
                } while (!next);

                Console.WriteLine("Rock (R), Paper (P), or Scissors (S)");
                handChoice = Console.ReadLine().ToLower();

                while (handChoice != "rock" &&  handChoice != "r" && handChoice != "paper" && handChoice != "p" && handChoice != "scissor" && handChoice != "s" && handChoice != "q" && handChoice != "quit")
                {
                    if (money <= 0)
                    {

                        Console.WriteLine("You don't have enough money to play. GAME OVER");
                        done = true;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Error, you did not pick either of the choices you were given, please try again.");
                    handChoice = Console.ReadLine().ToLower();
                }

                botHand = Generator.Next(3);

                if (handChoice == "quit" || handChoice == "q")
                {
                    next = false;

                    while (!next)
                    {
                        Console.WriteLine("You have earned a total of " + money.ToString("C"));
                        Console.WriteLine("Are you sure you want to end the game? Yes (Y) or No (N)");
                        handChoice = Console.ReadLine().ToLower();
                        if (handChoice == "yes" || handChoice == "y" || handChoice == "(y)")
                        {
                            Console.WriteLine("Thank you for playing. See you next time!");
                            next = true;
                            done = true;
                        }
                        else if (handChoice == "no" || handChoice == "n" || handChoice == "(n)")
                        {
                            next = true;
                        }
                        else
                        {
                            Console.WriteLine("You did not answer properly, please try again.");
                        }

                    }
                }
                else if (botHand == rock)
                {
                    Console.WriteLine("I picked rock");

                    if (handChoice == "paper" || handChoice == "p" || handChoice == "papers")
                    {
                        Console.WriteLine("You win");

                        money = bet + money;
                    }
                    else if (handChoice == "rock" || handChoice == "r" || handChoice == "rocks")
                    {
                        Console.WriteLine("Draw");
                    }
                    else if (handChoice == "scissor" || handChoice == "scissors" || handChoice == "s")
                    {
                        Console.WriteLine("You lose");

                        money = money - bet;
                    }
                }
                else if (botHand == paper)
                {
                    Console.WriteLine("I picked paper");

                    if (handChoice == "scissor" || handChoice == "scissors" || handChoice == "s")
                    {
                        Console.WriteLine("You win");

                        money = bet + money;
                    }
                    else if (handChoice == "rock" || handChoice == "r" || handChoice == "rocks")
                    {
                        Console.WriteLine("You lose");

                        money = money - bet;
                    }
                    else if (handChoice == "paper" || handChoice == "p" || handChoice == "papers")
                    {
                        Console.WriteLine("Draw");
                    }
                }
                else if (botHand == scissors)
                {
                    Console.WriteLine("I picked scissor");

                    if (handChoice == "rock" || handChoice == "rocks" || handChoice == "r")
                    {
                        Console.WriteLine("You win");

                        money = bet + money;
                    }
                    else if (handChoice == "paper" || handChoice == "p" || handChoice == "papers")
                    {
                        Console.WriteLine("You lose");

                        money = money - bet;
                    }
                    else if (handChoice == "scissor" || handChoice == "scissors" || handChoice == "s")
                    {
                        Console.WriteLine("Draw");
                    }
                }
            }
        }
    }
}
