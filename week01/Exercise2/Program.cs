using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade;
        string sign;

        // Core Requirement 1: Ask the user for their grade percentage, then write a series of if, else if, else statements to print out the appropriate letter grade.
        // Ask User for their grade percentage
        Console.Write("What is your Grade Percentage? ");
        string stringPercentage = Console.ReadLine();
        int intPercentage = int.Parse(stringPercentage);

        // If A
        if (intPercentage >= 90)
        {
            letterGrade = "A"; 
        }
        else if (intPercentage >= 80)
        {
        // If B
            letterGrade = "B";
        }
        else if (intPercentage >= 70)
        {
        // If C
            letterGrade = "C";
        }
        else if (intPercentage >= 60)
        {
        // If D
            letterGrade = "D";
        }
        else
        {
        // If F
            letterGrade = "F";
        }

        // Stretch Challange
        int mod = intPercentage % 10;

        if (intPercentage > 94  || intPercentage <= 60)
        {
            letterGrade = letterGrade;
        }
        else
        {
                if (mod >= 7)
            {
                sign = "+";
                letterGrade = letterGrade + sign;
            }
            else if (mod < 3)
            {
                sign = "-";
                letterGrade = letterGrade + sign;
            }
        }
           
        Console.WriteLine($"You got a {letterGrade} grade.");

        // Core Requirement 2: Assume that you must have at lease a 70 to pass the class. After determiing the letter grade and printing it out, add a separate if statement to determine if the user passed the course, and if so, display a message to congratulate them. If not, display a different message to encourage them for next time.

        if (intPercentage >= 70)
        {
            Console.WriteLine("You passed!!!");
        }
        else
        {
            Console.WriteLine("You failed the class. Better Luck next time");
        }

        // Core Requirement 3: Change your code from the first part, sot that instead of printing the letter grade in the body of each If, else if, else block, instead create a new variable called letter and then in each blcok, set this variable to the appropriate value. Finally,after the whole series of if ,statements, have a  single print statement that prints the letter grade once.
    }
}