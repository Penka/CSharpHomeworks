using System;
using System.Collections.Generic;
class NumberInArray
{
    static int NumberCount(int[] numbers, int number)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (number == numbers[i])
            {
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number {0} = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Number = ");
        int number = int.Parse(Console.ReadLine());

        int count = NumberCount(numbers, number);
        Console.WriteLine("The number {0} appears {1} times", number, count);
    }
}

