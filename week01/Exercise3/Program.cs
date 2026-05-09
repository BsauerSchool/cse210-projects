using System;

class Program
{
    static void Main(string[] args)
    {
        string guessString;
        int guess;

        // Core Requirement 1: Ask the user for the magic number
        // Core Requirement 3: Random number instead of asking for a magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        Console.WriteLine(magicNumber);
        
        // Core Requirement 2: Add a loop that keeps going until the magic number is guessed.
        do
        {
        // Ask the user for a guess
            Console.Write("What is your guess? "); 
            guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            // using an if statement ,determine higher, lower, or you guessed it.
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        } while (guess != magicNumber);
    }
}