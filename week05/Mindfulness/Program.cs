// Autthor Brendin Sauer
// CSE210 Mindfulness Project
using System;

class Program
{
    static void Main(string[] args)
    {
        MenuSelection();

        Activity activity = new Activity();
    }

    public static void MainMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
    }

    public static void MenuSelection()
    {
        MainMenu();
        string input = Console.ReadLine();
        int i = int.Parse(input);

        switch (i)
        {
            case 1:
                BreathingActivity b = new BreathingActivity();
                b.Run();
                break;
            case 2:
                ReflectingActivity r = new ReflectingActivity();
                r.Run();
                break;
            case 3:
                ListingActivity l = new ListingActivity();
                l.Run();
                break;
            case 4:
                Console.WriteLine("GoodBye");
                break;
            default:
                Console.WriteLine("Incorrect Selection. Please Select another option");
                break;

        }
    }
}