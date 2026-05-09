using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt User for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt User for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine();

        // Display the text back all on one line (Bond, james bond)
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}