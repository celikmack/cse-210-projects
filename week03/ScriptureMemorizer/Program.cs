using System;
using System.Security.Cryptography.X509Certificates;

/*
    Exceeding Requirement:
    I have added two more scriptures. When the first scripture is totally hidden, the program inform that there is a second one.
    The user can choice to continue or quit. The same happens until the last scripture.
*/

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        string text1 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        Scripture scripture1 = new Scripture(reference1, text1);

        Reference reference2 = new Reference("John", 3 , 16);
        string text2 = "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.";
        Scripture scripture2 = new Scripture(reference2, text2);

        Reference reference3 = new Reference("John", 17, 3);
        string text3 = "And this is life eternal, that they might know Thee the only true God, and Jesus Christ, whom Thou hast sent.";
        Scripture scripture3 = new Scripture(reference3, text3);

        Console.WriteLine("Let's start with Proverbs 3:5-6.");
        Console.Write("Press ENTER to begin. ");
        Console.ReadLine();
        RunMemorizer(scripture1);

        Console.WriteLine();
        Console.WriteLine("Well done! Now let's move on to John 3:16.");
        Console.Write("Press ENTER to continue. ");
        Console.ReadLine();
        RunMemorizer(scripture2);

        Console.WriteLine();
        Console.WriteLine("I'm proud of you! Let's try a last scripture, John 17:3.");
        Console.Write("Press ENTER to continue. ");
        Console.ReadLine();
        RunMemorizer(scripture3);
    }
    static void RunMemorizer(Scripture scripture)
    {    
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press ENTER to hide words or 'quit' to exit. ");
            string response = Console.ReadLine();

            if (response.ToLower() == "quit")
            {
                Console.WriteLine("You quit!");
                break;
            }

            scripture.HideRandomWord(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are hidden. You did it!");
                break;
            }
            
        }
        
    }


}