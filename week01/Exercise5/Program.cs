using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // DisplayWelcome - displays the message, "Welcome to the Program!"
        DisplayWelcom();

        // PromptUserName - asks for and returns the user's name (as a string)
        string name = PromptUserName();

        // PromptUserNumber - aks for and returns the users favorite number (as an int)
        int number = PromptUserNumber();

        // SquareNumber - accepts an integer as a parameter and returns that number squared (as an integer)
        int squaredNumber = SquareNumber(number);

        // DisplayResult - accepts the users name and the squared number and displays them
        DisplayResult(name, squaredNumber);
    }

    public static void DisplayWelcom()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    public static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    public static int PromptUserNumber()
    {
        Console.Write("Please enter you favorite number: ");
        string favstring = Console.ReadLine();
        int num = int.Parse(favstring);
        return num;
    }

    public static int SquareNumber(int num)
    {
        int squaredNumber = num * num;
        return squaredNumber;
    }

    public static void DisplayResult(string name, int num)
    {
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
}