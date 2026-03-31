using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Collections.Generic;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected int _count;
    protected List<string> _prevPrompt = new List<string>();
    protected List<string> _prevQuestion = new List<string>();

    public int Duration => _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"This activity will help you {_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!");
        ShowSpinner(3);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
        Console.Clear(); // Optional. See running and decide to keep it or not
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>
        {
            "|", "/", "-", "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i = (i + 1) % animationStrings.Count;
        }
    
        Console.WriteLine("Done.");
    }   
    public void ShowCountDown(int seconds)
    {
        for (int time = seconds; time > 0; time--)
        {
            Console.Write(time);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected string GetRandom(List<string> items, List<string> history)
    {
        Random genRandom = new Random();
        string selection = items[genRandom.Next(items.Count)];

        while (history.Contains(selection))
            selection = items[genRandom.Next(items.Count)];

        history.Add(selection);
        if (history.Count > 5) history.RemoveAt(0);

        return selection;
    }

    protected List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        List<string> entryList = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entry))
                entryList.Add(entry);
        }

        _count = entryList.Count;
        return entryList;
    }
}




