using System;
public class Activity 
{
    private DateTime _date; 
    private int _activityLength;

    public Activity(int duration)
    {
        _activityLength = duration;
        _date = DateTime.Now;
    }

    public virtual void GetSummary()
    {
         
    }

    public string GetDate()
    { 
        return $"{_date}";
    }

    public string GetActivityLength()
    {
        return $"{_activityLength}";
    }

    public virtual float CalculateDistance()
    {
        return 0;
    }

    public virtual float CalculateSpeed()
    {
        return 0;
    }

    public virtual float CalculatePace()
    {
        return 0;
    }
}