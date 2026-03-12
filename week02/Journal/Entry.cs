using System;
using System.Diagnostics.CodeAnalysis;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        DateTime now = DateTime.Now;
        _date = now.ToString("yyyy/MM/dd");
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}