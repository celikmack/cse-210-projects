using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int lengthMin, double distance)
        : base(date, lengthMin)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / LengthMin) * 60;
    }

    public override double GetPace()
    {
        return LengthMin / _distance;
    }
    
}