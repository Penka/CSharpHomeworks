using System;
using System.Collections.Generic;
class SumFromString
{
    static void Main(string[] args)
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int sum = 0;
        foreach (string number in numbers)
        {
            sum += int.Parse(number);
        }
        Console.WriteLine("The sum is {0}", sum);
    }
}

