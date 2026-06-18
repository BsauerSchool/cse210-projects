using System;
public class LapSwim: Activity
{
    private int _numberOfLaps;

    public LapSwim(int laps, int duration) : base(duration)
    {
        _numberOfLaps = laps;
    }
 
    public override float CalculatePace()
    {
        return float.Parse(GetActivityLength()) / CalculateDistance();
    }

    public override float CalculateSpeed()
    {
        return CalculateDistance() / float.Parse(GetActivityLength()) * 60;
    }

    public override float CalculateDistance()
    {
        double a = _numberOfLaps;

        double i = a * 50 /1000 * 0.62;
        return (float)i;
    }
    public override void GetSummary()
    {
Console.WriteLine($"{GetDate()} Pool Lap Swim ({GetActivityLength()} min): distance  {CalculateDistance()} miles, speed {CalculateSpeed()} mph, pace {CalculatePace()} min per mile\n");    }
}