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
                    Console.WriteLine("Rules:");
                    Console.WriteLine("\t 1: You will begin the with a base cash amount of $50.00.");
                    Console.WriteLine("\t 2: Your bet cannot exceed the total amount of cash you have");
                    Console.WriteLine("\t 3: If you lose a game it will cause you to lose the money you bet with");
                    Console.WriteLine("\t 4: If you win a game it will give you 2x the money you bet.");
                    Console.WriteLine("\t 5: If you want to end the game simply type quit or q");
                    Console.WriteLine("\t 6: If you run out of money, it will be a game over.");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to start the game");
                    Console.ReadLine();
                    next = true;
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


                    if (money <= 0)
                    {

                        Console.WriteLine("You don't have enough money to play. GAME OVER");
                        return;  //Simplifies exiting console
                    }
                    Console.WriteLine("You have " + money.ToString("C"));
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

                while (handChoice != "rock" && handChoice != "r" && handChoice != "rocks" && handChoice != "paper" && handChoice != "p" && handChoice != "papers" && handChoice != "scissor" && handChoice != "s" && handChoice != "papers" && handChoice != "q" && handChoice != "papers" && handChoice != "quit")
                {
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

                    pickRock();

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

                    pickPaper();

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

                    pickScissor();

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

        public static void pickRock()
        {
            Console.WriteLine("    _______");
            Console.WriteLine("---'   ____)");
            Console.WriteLine("      (_____)");
            Console.WriteLine("      (_____)");
            Console.WriteLine("      (____)\r\n");
            Console.WriteLine("---.__(___)\r\n");
        }

        public static void pickPaper()
        {
            Console.WriteLine("    _______\r\n");
            Console.WriteLine("---'   ____)______");
            Console.WriteLine("          ________)");
            Console.WriteLine("          _________)");
            Console.WriteLine("         _________)");
            Console.WriteLine("---.____________)");
        }

        public static void pickScissor()
        {
            Console.WriteLine("    _______\r\n")
            Console.WriteLine("---'   ____)_____");
            Console.WriteLine("          _______)");
            Console.WriteLine("       ___________)");
            Console.WriteLine("      (____)");
            Console.WriteLine("---.__(___)");
        }
    }
}
