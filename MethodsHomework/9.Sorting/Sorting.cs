using System;
using System.Collections.Generic;
class Sorting
{
    static List<int> SortDescending(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            int index;
            int max = MaxElement(numbers, i, out index);
            int tmp = numbers[i];
            numbers[i] = max;
            numbers[index] = tmp;
        }
        return numbers;


    }


    static List<int> SortAscending(List<int> numbers)
    {
        List<int> sorted = new List<int>();
        sorted = SortDescending(numbers);
        sorted.Reverse();
        return sorted;
    }
    
    static int MaxElement(List<int> numbers, int start, out int index)
    {
        index = start;
        //start is always in range
        int max = numbers[start];
        for (int i = start + 1; i < numbers.Count; i++)
        {
            if (max < numbers[i])
            {
                index = i;
                max = numbers[i];
            }
        }
        return max;
    }

    static void PrintNumbers(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + "  ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        /*Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>(n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number {0} = ", i);
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        Console.Write("Index = ");
        int index = int.Parse(Console.ReadLine());
        */

        List<int> numbers = new List<int>() { 1, 2, 9, 7, 4, 6 };
        Console.WriteLine("Numbers");
        PrintNumbers(numbers);

        List<int> sortedDecreasing = new List<int>();
        sortedDecreasing = SortDescending(numbers);
        Console.WriteLine("Sorted Decreasing: ");
        PrintNumbers(sortedDecreasing);

        List<int> sortedIncreasing = new List<int>();
        sortedIncreasing = SortAscending(sortedDecreasing);
        Console.WriteLine("Sorted Increasing: ");
        PrintNumbers(sortedIncreasing);
    }
}

