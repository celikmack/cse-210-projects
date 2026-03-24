using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "C# Classes";
        video1._author = "Bro Code";
        video1._lengthSeconds = 294;

        Video video2 = new Video();
        video2._title = "No Small Things";
        video2._author = "Tears for Fears";
        video2._lengthSeconds = 280;

        Video video3 = new Video();
        video3._title = "Funniest CATS of the Year";
        video3._author = "CaD Animals";
        video3._lengthSeconds = 1209;

        video1.Comments.Add(new Comment("@zoevanweerlee3865", "You are a legend, I'm studying it and my teachers explain it if I'm already experience. This is a huge help!"));
        video1.Comments.Add(new Comment("@prateekdindorkar8513", "This level of simple explanation is what we need understood this in a 4-min video."));
        video1.Comments.Add(new Comment("@hardicz2919", "You are explaining so well Bro! Thank u very much."));
            
        video2.Comments.Add(new Comment("@mariahrohmer2374", "I LOVE this album. Every fan should buy it. Radio stations should be playing it!"));
        video2.Comments.Add(new Comment("@Haleiysalas", "What a beautiful song that depicts an important message to all. Tears for Fears never loses its touch and talent! Love this song!"));
        video2.Comments.Add(new Comment("@ChuckMastersonHQ", "People who understand how to make music, they will never be out of date."));

        video3.Comments.Add(new Comment("@bakedbeetle", "No commentary, no obnoxious sound effects, hardly any captions, just cats. This is what the internet is for."));
        video3.Comments.Add(new Comment("@tamaraj4200", "No stupid over voices. Love it!"));
        video3.Comments.Add(new Comment("@LindseyN1223", "Cats are just pure chaos wrapped in a cute and fuzzy package, and I love that."));

        DisplayVideo(video1);
        DisplayVideo(video2);
        DisplayVideo(video3);
    }

    static void DisplayVideo(Video video)
    {
        video.DisplayVideoInfo();
        Console.WriteLine("Comments:");
        foreach (var Comment in video.Comments)
        {
            Comment.DisplayComment();
        }
        Console.WriteLine();
    }
}