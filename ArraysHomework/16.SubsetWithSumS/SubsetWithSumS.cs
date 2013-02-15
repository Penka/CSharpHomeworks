using System;
using System.Collections.Generic;
class SubsetWithSumS
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0}: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("sum = ");
        int sum= int.Parse(Console.ReadLine());
        int max = (int)Math.Pow(2, n);
        bool hasSumS = false;
        for (int i = 0; i < max; i++)
        {
            int curretntSum = 0;
            for (int j = 0; j < n; j++)
            {
                int bit = (i >> j) & 1;
                curretntSum = curretntSum + bit * numbers[j];
            }
            if (curretntSum == sum)
            {
                hasSumS = true;
                break;
            }
        }
        if (hasSumS)
        {
            Console.WriteLine("There is a subset that gives sum {0}", sum);
        }
        else
        {
            Console.WriteLine("There is not a subset that gives sum {0}", sum);
        }
    }
}

