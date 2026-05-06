using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        bool finished = false;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while(finished != true)
        {
            Console.Write("Enter Number: ");
            string addNumString = Console.ReadLine();
            int addNum = int.Parse(addNumString);

            if(addNum != 0)
            {
                numbers.Add(addNum);
            }
            

            if (addNum == 0)
            {
                finished = true;
            }
        }

        // Core Requirement 1: Compute the sum, or total, of the numbers in the list.
        int total = 0;
        int min = 0;
        int max = 0;
        foreach(int num in numbers)
        {
            total += num;

            // find max
            if(max == 0)
            {
                max = num;
            } 
            else if (num > max)
            {
                max = num;
            }

            // find min
            if(min == 0)
            {
                min = num;
            }
            else if (num < min && num > 0)
            {
                min = num;
            }

        }
        Console.WriteLine($"The sum is: {total}");

        // Core Requirement 2: Compute the average of the numbers in the list.
        float average = (float)total / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Core Requirement 3: Find the maximum, or largest, number in the list.
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");

        // sorted list
        numbers.Sort();
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }
        // Enter a list of numbers, type 0 when finished.
        // Enter number: 1
        // The sum is: 122
        // The average is: 22
        // The largest number is: 33
    }
}