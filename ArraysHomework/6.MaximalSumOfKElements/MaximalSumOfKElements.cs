using System;
class MaximalSumOfKElements
{
    static void Main(string[] args)
    {
        Console.Write("enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("enter element at index {0} ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("enter k: ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(numbers);
        int maximalSum = 0;
        for (int i = n - k; i < n; i++)
        {
            maximalSum += numbers[i];
        }
        Console.WriteLine("the maximal sum is: " + maximalSum);
    }
}

