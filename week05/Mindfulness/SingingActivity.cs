using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.InteropServices;


public class SingingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Ocean",
        "Mountain or Mountains",
        "Heaven",
        "Happiness or Happy",
        "Family",
        "Blessing or Blessed",
        "God or Lord",
        "Hope",
        "Faith",
        "Love",
        "Child or Children",
        "Freedom or Free",
    };
    private List<string> _questions = new List<string>
    {
        "What feelings do you feel while singing?",
        "List the name of the people that came to your mind.",
        "List the places that came to your mind.",
        "What people did you wish to be with?",
        "what places did you wish to go?",
        "What goals did plan to accomplish?",
        "What are the things that you will do different from now on?",
        "How many blessings or good moments can you list now?",
        "What inspirations have you received while singing?",
    };
    public SingingActivity(int duration)
        : base("Singing", "connect to fond memories and uplifting feelings. This activity will help you relax and have a good day or a good night's sleep.", duration)
    {
        
    }
    public void Run()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.WriteLine("Get ready... ");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine("Choose a song that contains the word (You can play it from your playlist!):");
        Console.WriteLine($" --- {GetRandom(_prompts, _prevPrompt)} ---");
        

        Console.WriteLine("When you finish singing, press ENTER to continue.");
        Console.ReadLine();

        Console.WriteLine("List as many responses you can to the following question:");
        Console.WriteLine($" --- {GetRandom(_questions, _prevQuestion)} ---");
        Console.WriteLine();
       
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> responses = GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }    
}   



