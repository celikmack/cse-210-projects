using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the biggest challenge I faced today, and how did I handle it?",
        "What have I learnt from my study of the scriptures today?",
    };

    public string GetRandomPrompt()
    {
        Random genRandom = new Random();
        int i = genRandom.Next(_prompts.Count);
        return _prompts[i];
    }
}