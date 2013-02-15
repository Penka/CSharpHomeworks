using System;
using System.Collections.Generic;
class MaximalSumInArray
{

    static List<int> MaxSequence(List<int> numbers)
    {
        List<int> maxSequence = new List<int>();
        int maxSum = numbers[0];
        int currentMax = numbers[0];
        int start = 0;
        int startIndex = 0;
        int end = 0;
        for (int i = 1; i < numbers.Count; i++)
        {
            currentMax += numbers[i];
            if (numbers[i] > currentMax)
            {
                currentMax = numbers[i];
                startIndex = i;

            }

            if (currentMax > maxSum)
            {
                maxSum = currentMax;
                start = startIndex;
                end = i;
            }
        }
        for (int i = start; i <= end; i++)
        {
            maxSequence.Add(numbers[i]);
        }
        return maxSequence;
    }


    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        List<int> maxSequence = new List<int>();
        maxSequence = MaxSequence(numbers);
        foreach (var number in maxSequence)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

