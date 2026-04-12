using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    
    public Activity(){
        
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity\n\n");
        Console.WriteLine();

        Console.WriteLine("How Long, in seconds, would you like your session to be? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!\n\n");
        Console.WriteLine($"You have completed another {_duration} Seconds of the {_name} Activity");
    }

    public void ShowSpinner(int seconds)
    {
        // Creating the list for the spinner items
        List<char> spinner = new List<char>();
        spinner.Add('|');
        spinner.Add('/');
        spinner.Add('-');
        spinner.Add('\\');
        spinner.Add('|');
        spinner.Add('/');
        spinner.Add('-');
        spinner.Add('\\');

        // initiating the timer and the char swap
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            char s = spinner[i];
            
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        //int i = seconds;
        
        for (int i = seconds; i > 0; i--)
        {
            if (i > 9)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b  \b\b");  
            }
            else
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");  
            }
        }
        Console.WriteLine();
        
    }
}