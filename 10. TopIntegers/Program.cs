using System;
using System.Collections.Generic;

class Program
{
    static List<int> FindTopIntegers(List<int> numbers)
    {
        List<int> topIntegers = new List<int>();
        int maxRight = int.MinValue;

        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            int num = numbers[i];
            if (num > maxRight)
            {
                topIntegers.Add(num);
            }
            maxRight = Math.Max(maxRight, num);
        }

        topIntegers.Reverse();
        return topIntegers;
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(' ');

        List<int> numbers = new List<int>();
        foreach (string inputNumber in inputNumbers)
        {
            if (int.TryParse(inputNumber, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"Invalid input: '{inputNumber}' is not an integer.");
                return;
            }
        }

        List<int> topIntegers = FindTopIntegers(numbers);

        
        Console.WriteLine(string.Join(" ", topIntegers));
    }
}
