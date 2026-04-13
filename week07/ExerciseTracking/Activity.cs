using System;

public abstract class Activity
{
    private string _date;
    private int _lengthMin;

    public Activity(string date, int lengthMin)
    {
        _date = date;
        _lengthMin = lengthMin;
    }

    public string Date => _date;
    public int LengthMin => _lengthMin;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return  $"{_date} {GetType().Name} ({LengthMin} min) - Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per Km.";
    }
}