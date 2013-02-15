using System;
using System.Collections.Generic;

class SortedArray
{
    static List<int> MaxIncreasingSubsequence(int[] numbers)
    {
        int max = 0;
        int[] q = new int[numbers.Length];
        List<int> result = new List<int>();
        int[] parents = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            parents[i] = -1;
            max = 0;
            for (int j = 0; j < i; j++)
            {
                if (numbers[i] >= numbers[j])
                {
                    if (q[j] > max)
                    {
                        max = q[j];
                        parents[i] = j;
                    }
                }
            }
            q[i] = max + 1;
        }
        max = 0;
        int index = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (q[i] > max)
            {
                max = q[i];
                index = i;
            }
        }
        result.Add(numbers[index]);
        while (parents[index] != -1)
        {
           
            index = parents[index];
            result.Add(numbers[index]);
        }
        return result;
    }


    static void Main(string[] args)
    {
        int[] numbers = new int[] { 6, 1, 4, 3, 0, 3, 6, 4,5 };
        List<int> result = new List<int>();
        result = MaxIncreasingSubsequence(numbers);
        result.Reverse();
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}

