using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (i == 0)
            {
                Console.Write("Breathe In...");
                ShowCountDown(2);
                Console.Write("Breathe Out...");
                ShowCountDown(3);
                i++;
            }
            else
            {
                Console.Write("Breathe In...");
                ShowCountDown(4);
                Console.Write("Breathe Out...");
                ShowCountDown(6);
                i++;
            }
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}