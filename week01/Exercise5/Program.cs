using System;

class Program
{
    static void DisplayWelcome()
    {
// DisplayWelcome - Displays the message, "Welcome to the Program!"
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
// PromptUserName - Asks for and returns the user's name (as a string)
        string name;

        Console.Write("Please enter your name: ");
        name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        Console.Write("Enter your favorite number ");
        string number = Console.ReadLine();
        
        int num = int.Parse(number);
        return num;
    }

    static int SqaureNumber(int number)
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    {
        int num = number * number;
        return num;
    }

    static void DisplayResult(string name, int number)
    {
// DisplayResult - Accepts the user's name and the squared number and displays them.
        Console.WriteLine($"{name}, the square of your number is {number}");
    }


    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNum = SqaureNumber(number);
        DisplayResult(name, squaredNum);
    }
}


