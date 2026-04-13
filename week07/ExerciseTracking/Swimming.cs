using System;

public class Swimming : Activity
{
    private int _numberLaps;

    public Swimming(string date, int lengthMin, int numberLaps)
        : base(date, lengthMin)
    {
        _numberLaps = numberLaps;  
    }

    public override double GetDistance()
    {
        return _numberLaps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthMin) * 60;
    }

    public override double GetPace()
    {
        return LengthMin / GetDistance();
    }
}