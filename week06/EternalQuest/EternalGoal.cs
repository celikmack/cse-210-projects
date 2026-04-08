using System;
using System.Drawing;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base (shortName, description, points)
    {
    }

    public override int RecordEvent()
    {
       return GetPoints();
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{GetShortName()} ({GetDescription()} - {GetPoints()} points (Never completed)";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{GetShortName()},{GetDescription()},{GetPoints()}";
    }

    public override string GetCheckbox()
    {
        return $"[ ] {GetShortName()} ({GetDescription()}) - {GetPoints()} points (Eternal)";
    }
    
}