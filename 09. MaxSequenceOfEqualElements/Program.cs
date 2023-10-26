using System;
using System.Collections.Generic;

class Program
{
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

        List<int> longestSequence = FindLongestEqualSequence(numbers);

        if (longestSequence.Count > 0)
        {
            
            Console.WriteLine(string.Join(" ", longestSequence));
        }
        else
        {
            Console.WriteLine("No equal sequences found.");
        }
    }

    static List<int> FindLongestEqualSequence(List<int> numbers)
    {
        List<int> longestSequence = new List<int>();
        List<int> currentSequence = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (i == 0 || numbers[i] == numbers[i - 1])
            {
                currentSequence.Add(numbers[i]);
            }
            else
            {
                currentSequence.Clear();
                currentSequence.Add(numbers[i]);
            }

            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence.Clear();
                longestSequence.AddRange(currentSequence);
            }
        }

        return longestSequence;
    }
}
