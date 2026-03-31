using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    public ListingActivity(int duration)
        : base("Listing", "reflect on good things in your life by having you list as many things as you can in a certain area.",duration)
    {
        
    }    

    public void Run()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.WriteLine("Get ready... ");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt:");
        string selectedPrompt = GetRandom(_prompts, _prevPrompt);
        Console.WriteLine($" --- {selectedPrompt} ---");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> responses = GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }
}
    