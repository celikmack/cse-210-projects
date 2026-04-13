using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int lengthMin, double speed)
        : base (date, lengthMin)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * LengthMin /60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}