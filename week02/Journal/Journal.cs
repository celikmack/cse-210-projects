using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private string _filename;
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - {entry._promptText}");
            Console.WriteLine($"{entry._entryText}");
        }
    }
    public void SaveToFile(string filename)
    {
        _filename = filename;

        using (StreamWriter output = new StreamWriter(_filename))
        {
            foreach (Entry e in _entries)
            {
                output.WriteLine($"{e._date}, {e._promptText}, {e._entryText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        _filename = filename;
        _entries = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            Entry newEntry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };

            _entries.Add(newEntry);
        }
    }
    public void SearchByDate(string _date)
    {
        bool found = false;

        foreach(Entry entry in _entries)
        {
            if (entry._date.StartsWith(_date))
            {
                entry.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"It seems that you didn't write in {_date}");
        }
    }
    public void SearchByWord(string word)
    {
        bool found = false;

        foreach (Entry entry in _entries)
        {
            if (entry._entryText.Contains(word) || entry._promptText.Contains(word))
            {
                entry.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"'{word}' not found or mispelled.");
        }
    }
}