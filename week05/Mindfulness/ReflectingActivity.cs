using System;

public class ReflectingActivity: Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the Following Prompt: ");
        DisplayPrompt();
        Console.WriteLine("When You have something in mind, press Enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now Ponder on each of the following questions as they relate to this experience");
        Console.Write("You may begin in...");
        ShowCountDown(4);

        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            Thread.Sleep(5000);
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random r = new Random();
        int i =r.Next(0, _prompts.Count-1);
        return _prompts[i];
    }

    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random r = new Random();
        int i =r.Next(0, _questions.Count-1);
        return _questions[i];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
        Console.WriteLine();
    }
}