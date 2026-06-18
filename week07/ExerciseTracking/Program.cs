using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running run = new Running(10, 60);

        StationaryBike bike = new StationaryBike(4,25);

        LapSwim swim = new LapSwim(50, 20);

        List<Activity> activity = new List<Activity>();

        activity.Add(run);
        activity.Add(bike);
        activity.Add(swim);

        foreach(Activity a in activity)
        {
            a.GetSummary();
        }        
    }
}