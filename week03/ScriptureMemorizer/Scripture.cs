using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class Scripture
{
        private Reference _reference;
        private List<Word> _words;
        private static Random _random = new Random();
       
        public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }    
    public void HideRandomWord(int numberToHide)
    {
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {text}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}

