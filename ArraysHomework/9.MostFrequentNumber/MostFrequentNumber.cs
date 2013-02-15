using System;
using System.Collections.Generic;
class MostFrequentNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        int currentFrequentCount = 1;
        int mostFrequentCount = 1;
        int index = 0;
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentFrequentCount++;
            }
            else
            {
                currentFrequentCount = 1;
            }
            if (currentFrequentCount > mostFrequentCount)
            {
                mostFrequentCount = currentFrequentCount;
                index = i;
            }
        }
        Console.WriteLine("The most frequent element is {0} ({1} times)", numbers[index], mostFrequentCount);
    }
}

