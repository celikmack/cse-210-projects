using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Classes", "Bro Code", 294 );
        video1.AddComment(new Comment("@zoevanweerlee3865", "You are a legend, I'm studying it and my teachers explain it if I'm already experience. This is a huge help!"));
        video1.AddComment(new Comment("@prateekdindorkar8513", "This level of simple explanation is what we need understood this in a 4-min video."));
        video1.AddComment(new Comment("@hardicz2919", "You are explaining so well Bro! Thank u very much."));
        videos.Add(video1);

        Video video2 = new Video("No Small Things", "Tears for Fears", 280);
        video2.AddComment(new Comment("@mariahrohmer2374", "I LOVE this album. Every fan should buy it. Radio stations should be playing it!"));
        video2.AddComment(new Comment("@Haleiysalas", "What a beautiful song that depicts an important message to all. Tears for Fears never loses its touch and talent! Love this song!"));
        video2.AddComment(new Comment("@ChuckMastersonHQ", "People who understand how to make music, they will never be out of date."));
        videos.Add(video2);

        Video video3 = new Video("Funniest CATS of the Year", "CaD Animals", 1209);
        video3.AddComment(new Comment("@bakedbeetle", "No commentary, no obnoxious sound effects, hardly any captions, just cats. This is what the internet is for."));
        video3.AddComment(new Comment("@tamaraj4200", "No stupid over voices. Love it!"));
        video3.AddComment(new Comment("@LindseyN1223", "Cats are just pure chaos wrapped in a cute and fuzzy package, and I love that."));
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            Console.WriteLine($"\nTitle: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberofComments()}");
            Console.WriteLine("\nComments:");

            foreach (Comment comment in video.GetComments())
            {
                comment.DisplayComment();
            }
        }           
    }
}