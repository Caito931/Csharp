
using System;
using System.Net.WebSockets;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // Number Guessing Game

            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            // While User Wants to Play
            while (playAgain)
            {
                // Setup
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max+1);

                // While User Doens't Guess Correctly
                while (guess != number)
                {
                    // Ask
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    // Hint
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }

                    guesses += 1;
                }

                // Final Part
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win!");
                Console.WriteLine("Guesses: " + guesses);
                Console.WriteLine("Would yu like to play again? (y/n)");
                response = Console.ReadLine();
                response = response.ToLower();

                // Response
                if (response == "y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            // Final Feedback
            Console.WriteLine("Thanks for playing! .. I guess");
            
            Console.ReadKey(); 
        } 
    } 
}
