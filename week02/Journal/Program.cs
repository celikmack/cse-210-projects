using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

/* Exceeding requirements:
    I always search an event in my journal.
    I've added two methods to make the search by date and by word. They are in the Journal class.
    It helps the user find an event quickly. They do not have to guess a date.
*/

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        Console.WriteLine("*******************************");
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("*******************************");

        Console.WriteLine("Please select one of the following choices:");

        while (true)
        {
            Console.WriteLine("  1. Write");
            Console.WriteLine("  2. Display");
            Console.WriteLine("  3. Load");
            Console.WriteLine("  4. Save");
            Console.WriteLine("  5. Search by Date");
            Console.WriteLine("  6. Search by Word");
            Console.WriteLine("  7. Quit");

            Console.Write("\n What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string userResponse = Console.ReadLine();

                    Entry newEntry = new Entry
                    {
                        _prompText = prompt,
                        _entryText = userResponse
                    };

                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write($"Enter filename to load: ");
                    string filename = Console.ReadLine();
                    journal.LoadFromFile(filename);        
                    break;

                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "5":
                    Console.Write("Enter date to search (yyyy/MM/dd): ");
                    string searchDate = Console.ReadLine();
                    journal.SearchByDate(searchDate);
                    break;

                case "6":
                    Console.Write("Enter word to search: ");
                    string searchWord = Console.ReadLine();
                    journal.SearchByWord(searchWord);
                    break;

                case "7":
                    Console.WriteLine("Don't forget to return tomorrow!");
                    return;

                default:
                    Console.WriteLine("Number invalid!");
                    break;                                   
            }
        }
    }
}