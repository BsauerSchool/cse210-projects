using System;
public class StationaryBike : Activity
{
    private int _speed;

    public StationaryBike(int speed, int duration) : base(duration){
        _speed = speed;
    }

    public override float CalculatePace()
    {
        return 60 / _speed;
    }

    public override float CalculateSpeed()
    {
        return _speed;
    }

    public override float CalculateDistance()
    {
        return _speed * CalculatePace();
    }

    public override void GetSummary()
    {
Console.WriteLine($"{GetDate()} Stationary Bike ({GetActivityLength()} min): distance  {CalculateDistance()} miles, speed {CalculateSpeed()} mph, pace {CalculatePace()} min per mile\n");    }
}