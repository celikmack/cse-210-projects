using System;
using System.Collections.Generic;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthSeconds;

    public List<Comment> Comments = new List<Comment>();

    public int NumberofComments()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Number of Comments: {NumberofComments()}");
    }
}


