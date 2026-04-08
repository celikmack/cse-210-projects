using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base (name, description, points)
    {
        _isComplete = isComplete;
    }
    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("You did it!. Let's make a new goal?");
            return 0;
        }

        else
        {
            _isComplete = true;
            return GetPoints(); 
        }      
    }

    public override bool IsComplete() 
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{GetShortName()} ({GetDescription()}) - {GetPoints()} points - Completed: {_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }

    public override string GetCheckbox()
    {
        string checkbox = IsComplete() ? "[x]" : "[ ]";
        return $"{checkbox} {GetShortName()} ({GetDescription()}) - {GetPoints()} points";
    }

}