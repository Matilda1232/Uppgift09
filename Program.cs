using System;

namespace Uppgift09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! We're about to play Rock, Paper, Scissors.");

            Random number = new Random();
            

            Console.WriteLine ("You are playing against the computer. Type 1 for Rock, 2 for Paper or 3 for Scissors!");
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
            
            




            Console.ReadKey();

        }

        
        
            

        

        
    }
}
