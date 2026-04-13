using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Running running = new Running("09 Apr 2026", 30, 4.8);
        Cycling cycling = new Cycling("10 Apr 2026", 50, 38.0);
        Swimming swimming = new Swimming("11 Apr 2026", 40, 27);

        _activities.Add(running);
        _activities.Add(cycling);
        _activities.Add(swimming);

        foreach(Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary()); 
        }
    }
}