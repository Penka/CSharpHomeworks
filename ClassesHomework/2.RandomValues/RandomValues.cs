using System;
using System.Collections.Generic;
class RandomValues
{
    private static Random randomGenerator = new Random();

    static void Main(string[] args)
    {
        int n = 10;
        int start = 100;
        int end = 200 + 1;
        for (int i = 0; i < n; i++)
        {
            int randomValue = randomGenerator.Next(start, end);
            Console.WriteLine(randomValue);
        }
    }
}

