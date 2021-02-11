using System;

namespace Uppgift09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rock, paper, scissors";
            Console.ForegroundColor = ConsoleColor.Magenta;
            
            Console.WriteLine("Welcome! We're about to play Rock, Paper, Scissors.");

            Random number = new Random();
            
            int playerScore = 0;
            int computerScore = 0;

            Console.WriteLine ("You are playing against the computer. Type 1 for Rock, 2 for Paper or 3 for Scissors!");
           
           goAgain:

            int player1Choice = Convert.ToInt32(Console.ReadLine ());

            switch (player1Choice)
            {
                case 1:
                Console.WriteLine ("You chose Rock!" );
                break;
                case 2:
                Console.WriteLine ("You chose Paper!" );
                break;
                case 3:
                Console.WriteLine ("You chose Scissors!" );
                break;
            }

            int computerChoice = number.Next(1,4);
             
             switch (computerChoice)
            {
                case 1:
                Console.WriteLine ("The computer chose Rock!" );
                break;
                case 2:
                Console.WriteLine ("The computer chose Paper!" );
                break;
                case 3:
                Console.WriteLine ("The computer chose Scissors!" );
                break;
            }

            if (player1Choice == computerChoice)
            {
                Console.WriteLine ("It's a tie!");
            }
             else if (player1Choice == 1 && computerChoice == 3)
             {
                 Console.WriteLine ("You won, well done!");
                 playerScore++;
             }

            else if (player1Choice == 2 && computerChoice == 1)
            {
                Console.WriteLine ("You won, well done!");
                playerScore++;
            }
             else if (player1Choice == 3 && computerChoice == 2)
            {
                Console.WriteLine ("You won, well done!");
                playerScore++;
            }
            else
            {
                Console.WriteLine ("The computer won! Better luck next time!");
                computerScore++;
            }
        
        Console.WriteLine ("Do you want to play again? Please answer 'yes' or 'no'");
        string playAgain = Console.ReadLine ();

        if (playAgain == "yes")
        {
            Console.WriteLine ("Welcome back! Type 1 for Rock, 2 for Paper or 3 for Scissors!");
            goto goAgain;
        }

        else
        {
            Console.WriteLine ("Thanks for playing, see you another time!");
            Console.WriteLine ("You won " + playerScore + " times. The computer won " + computerScore + " times.");
        }



            Console.ReadKey();

        }

        
        
            

        

        
    }
}
