using System;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
namespace rock_paper_scissors {
    class Program {
        static void Main(string[] args)
        {
            // Set app color scheme
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            // Initialize both scores as 0
            int computerScore;
            int playerScore;

            // Create variables to hold input from both players
            int computerInput;
            int playerInput;

            // Create a random number and store it in a variable to use as the computer's input generator.
            int randomNum = random.Next(1,4);

            while (true) {
                Console.WriteLine("GIANTS BEAT ELVES, ELVES BEAT WIZARD, WIZARDS BEAT GIANTS.")
                Console.WriteLine("CHOOSE YOUR FIGHTER.");
                Console.WriteLine("1 - GIANT");
                Console.WriteLine("2 - WIZARD");
                Console.WriteLine("3 - ELF");

            switch (randomNum)
            {
                case 1: 
                computerInput = 1;
                Console.WriteLine("COMPUTER CHOSE GIANT");
                if (inputPlayer == 1)
                {
                    Console.WriteLine("BEEP BOOP, IT'S A DRAW");
                }
                else if (inputPlayer == 3)
                {
                    Console.WriteLine("YOU WIN\n\n");
                    playerScore++;
                }
                else if (inputPlayer == 2)
                {
                    Console.WriteLine("COMPUTER WINS BEEP BOOP\n\n");
                    computerScore++;
                }
                break;
            }
            }
        }
    }
}