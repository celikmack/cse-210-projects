using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string playAgain; // Strecth Challenge

        do
        {
            int userNumber = random.Next(1, 100);
            int guessCount = 0; // Strecth Challenge
            int guess = -1;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount ++; // Stretch challenge

                if (userNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (userNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("\nYou guessed it!");
                }
            } while (guess != userNumber);
            // Strecth Challenge
            Console.WriteLine($"It took you {guessCount} guesses.");
            Console.Write("Would you like to play again (yes/no)? ");
            playAgain = Console.ReadLine().ToLower();
            
        } while (playAgain == "yes");

        Console.WriteLine("Thank you for playing. Goodbye!");

    }    
}