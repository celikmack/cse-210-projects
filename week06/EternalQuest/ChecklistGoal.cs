using System;
using System.Threading;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus,int amountCompleted = 0) 
    : base (shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        int reward = GetPoints();

        if (_amountCompleted >= _target)
        {
            reward += _bonus;
            ShowCelebration();
        }

        return reward;
    }

    private void ShowCelebration()
    {
        string message = "** You finished your checklist goal! **";
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(80);
        }
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("*************************");
        Console.WriteLine("**  CONGRATULATIONS!!! **");
        Console.WriteLine("*************************");
        Console.ResetColor();
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{GetShortName()} ({GetDescription()}) (Progress: {_amountCompleted}/{_target}), Points: {GetPoints()}, Bonus: {_bonus}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_amountCompleted},{_target}";
    }

    public override string GetCheckbox()
    {
        string checkbox = IsComplete() ? "[x]" : "[ ]";
        return $"{checkbox} {GetShortName()} ({GetDescription()}) " + 
               $"Progress: {_amountCompleted}/{_target}, Points: {GetPoints()}, Bonus: {_bonus}"; 
    }
}