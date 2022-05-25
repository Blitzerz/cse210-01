using System;

namespace solo_prep_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize "restart" variable.
            string restart = "y";
            
            // Nested while loop to continue prompting user for a number
            // until they enter "no".
            while (restart.ToLower() == "y")
            {   
                // Create instance of Random class to generate random
                // number between 1-10.
                Random randomGenerator = new Random();
                int randomNum = randomGenerator.Next(1,11);

                // Declare and initialize counter variable to hold the number
                // of guesses.
                int guesses = 0;
            
                // Declare and initialize "userInput" variable.
                int guess = 0;

                while (guess != randomNum)
                {
                    Console.Write("Enter your guess: ");
                    guess = int.Parse(Console.ReadLine());
                    guesses += 1;

                    if (guess < randomNum)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > randomNum)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("\nCorrect!");
                        Console.WriteLine($"You guessed {guesses} times");
                        Console.Write("\nDo you want to play again? Type 'y' for yes: ");
                        restart = Console.ReadLine().ToLower();
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}