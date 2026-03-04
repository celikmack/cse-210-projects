using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine("Welcome to the program!");
        Console.WriteLine("-----------------------");
    }

    static string PromptUserName()
    {
        Console.Write("\nEnter your name: ");
        string response = Console.ReadLine();
        return response;
    }

    static int PromptUserNumber()
    {
        Console.Write("What's your favorite number? ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}