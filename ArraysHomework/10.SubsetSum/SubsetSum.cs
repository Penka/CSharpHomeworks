using System;
using System.Collections.Generic;

class SubsetSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int s = int.Parse(Console.ReadLine());
        List<int> sequence = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = i; j < n; j++)
            {
                sum = sum + numbers[j];
                if (sum == s)
                {
                    for (int k = i; k <= j; k++)
                    {
                        sequence.Add(numbers[k]);
                    }
                }
            }
        }

        foreach (int element in sequence)
        {
            Console.WriteLine(element);
        }
    }
}

