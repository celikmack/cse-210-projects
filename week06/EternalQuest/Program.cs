using System;

/*
I've added a welcome message at the beginning of the program (GoalManager class).
I've added a ShowCelebration method to congratulate the user when a checklist goal is completed (ChecklistGoal class).
*/
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}