using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number, positive or negative (0 to quit): ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } 

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }   
        Console.WriteLine($"\nThe sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number is: {max}");

        // Stretch Challenge
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The min number is {min}");

        int smallestPositive = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number is {smallestPositive}");

        int highestNegative = int.MinValue;

        foreach (int number in numbers)
        {
            if (number < 0 && number > highestNegative)
            {
                highestNegative = number;
            }
        }
        Console.WriteLine($"the highest negative number is: {highestNegative}");

        numbers.Sort();
        Console.WriteLine("the sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}