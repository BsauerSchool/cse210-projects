using System;

class Program
{
    static void Main(string[] args)
    {  
// Random number generator
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,99);
        
        int numberOfGuesses = 0;
        string stringGuess;
        int guess;

        do
        {
            Console.Write("What is your guess? ");
            stringGuess = Console.ReadLine();
            guess = int.Parse(stringGuess);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            numberOfGuesses += 1;
        } while (guess != number);
        Console.WriteLine("You Guessed it!!");
        Console.WriteLine($"Total number of guesses: {numberOfGuesses}");

    }
}