using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        bool finished = false;
        int number;
        int total = 0;
        float average = 0;
        int min = 100000000;
        int max = 0;

        List <int> numbersList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

// Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0. (Remember: You should not add 0 to the list. If you do, later calculations and operations will not be correct.)
        while (finished == false)
        {
            Console.Write("Enter Number: ");
            String stringNumber = Console.ReadLine();
            number = int.Parse(stringNumber);

            if (number == 0)
            {
                finished = true;
            }
            else
            {
                numbersList.Add(number);
            }
        }
// Compute the sum, or total, of the numbers in the list.
        foreach (int num in numbersList)
        {
            total += num; 
// Find the maximum, or largest, number in the list.
           
            if (num > max)
            {
                max = num;
            }
            else if (num < min && num > 0)
            {
                min = num;
            }

        }
// Compute the average of the numbers in the list.
        int count = numbersList.Count;
        average = (float)total / (float)count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
        Console.WriteLine("The sorted list is: ");

        numbersList.Sort();
        foreach (int num in numbersList)
        {
            Console.WriteLine(num);
        }

    }

}
