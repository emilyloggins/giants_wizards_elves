using System;


namespace rock_paper_scissors {
    class Program {
        static void Main(string[] args)
        {
            // Set app color scheme
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            // Initialize both scores as 0
            int computerScore = 0;
            int playerScore = 0;

            // Create variables to hold input from both players
            // string computerInput;
            string playerInput = Console.ReadLine();
            // int playerInput;

            // Create a random number and store it in a variable to use as the computer's input generator.
            Random rnd = new Random();
            int randomNum = rnd.Next(1,4);

            while (true) {
                Console.WriteLine("GIANTS BEAT ELVES, ELVES BEAT WIZARD, WIZARDS BEAT GIANTS.");
                Console.WriteLine();
                Console.WriteLine("CHOOSE YOUR FIGHTER.");
                Console.WriteLine("1 - GIANT");
                Console.WriteLine("2 - WIZARD");
                Console.WriteLine("3 - ELF");

            switch (randomNum)
            {
                    case 1: 
                    // computerInput = "1";
                    Console.WriteLine("COMPUTER CHOSE GIANT");
                    // string playerInput = Console.ReadLine();
                    if (playerInput == "1")
                        {
                            Console.WriteLine("BEEP BOOP, IT'S A DRAW");
                        }
                    else if (playerInput == "3")
                        {
                            Console.WriteLine("YOU WIN!\n\n");
                            playerScore++;
                        }
                    else if (playerInput == "2")
                        {
                            Console.WriteLine("COMPUTER WINS BEEP BOOP\n\n");
                            computerScore++;
                        }
                    break;
                    case 2:
                    // computerInput = "2";
                    Console.WriteLine("COMPUTER CHOSE WIZARD");
                    if (playerInput == "1")
                        {
                            Console.WriteLine("YOU WIN!\n\n");
                            playerScore++;
                        }
                    else if (playerInput == "2")
                        {
                            Console.WriteLine("BEEP BOOP, IT'S A DRAW");
                        }
                    else if (playerInput == "3")
                        {
                            Console.WriteLine("COMPUTER WINS BEEP BOOP\n\n");
                            computerScore++;
                        }
                    break;
                    case 3:
                    // computerInput = "3";
                    Console.WriteLine("COMPUTER CHOSE ELF");
                    if (playerInput == "1")
                            {
                                Console.WriteLine("COMPUTER WINS BEEP BOOP\n\n");
                                computerScore++;
                            }
                    else if (playerInput == "2")
                            {
                                Console.WriteLine("YOU WIN!\n\n");
                                playerScore++;
                            }
                    else if (playerInput == "PAPER")
                            {
                               Console.WriteLine("BEEP BOOP, IT'S A DRAW");
                            }
                    break;
                    default:
                        Console.WriteLine("PLAY BY THE RULES PUNK.");
                        break;
                }
            }
        }
    }
}