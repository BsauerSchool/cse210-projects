using System;
public class Running : Activity
{
    private int _distance;

    public Running(int distance, int duration) : base(duration)
    {
        _distance = distance;

    }

    public override float CalculatePace()
    {
        return float.Parse(GetActivityLength()) / _distance;
    }

    public override float CalculateSpeed()
    {
        return _distance / float.Parse(GetActivityLength()) * 60;
    }

    public override float CalculateDistance()
    {
        return _distance;
    }
// 03 nov 2-22 running(30 min): distance 3.0 miles, speed 6.0 mph, pace 10.o min per mile
    public override void GetSummary() 
    {
        Console.WriteLine($"{GetDate()} Running ({GetActivityLength()} min): distance  {_distance} miles, speed {CalculateSpeed()} mph, pace {CalculatePace()} min per mile\n");
    }
}