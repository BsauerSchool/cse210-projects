using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);


// Determine The Letter Grade
        string letterGrade;

        if (gradePercentage >= 90)
        {  
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";        }
        else if (gradePercentage >= 70)
        {
           letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
           letterGrade = "D";
        }
        else
        {
           letterGrade = "F";
        }

// Determine if they got a + or -
        int x = gradePercentage % 10;
        string sign = "";
        
        if (x < 3)
            {
                sign = "-";  
            }
            else if (x >= 7)
            {
// Handling values greater than or equal to 97
                if (gradePercentage >= 97)
                    {
                        sign = "";
                    }
                    else
                    {
                        sign = "+";
                    }
            }
        
// Letter Grade Print Statement
        Console.WriteLine($"You got a {letterGrade}{sign}");

// Determine if the user passed or failed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, You've passed!!!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you didn't pass. Better Luck next time");
        }
    }
}