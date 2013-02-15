using System;
using System.Collections.Generic;

class Indices
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        string[] numbersString = input.Split(' ');

        bool[] used = new bool[n];
        int[] numbers = new int[n];
        int index = 0;
        bool cycle = false;
        int cycleStart = -1;
        List<int> result = new List<int>(n);
        while (index >= 0 && index < numbers.Length)
        {
            numbers[index] = int.Parse(numbersString[index]);
            if (used[index])
            {
                cycle = true;
                cycleStart = index;
                break;
            }
            result.Add(index);
            used[index] = true;
            index = numbers[index];

        }

        for (int i = 0; i < result.Count; i++)
        {
            if (result[i] == cycleStart)
            {
                Console.Write("(");
            }
            else if (i != 0)
            {
                Console.Write(" ");
            }
            Console.Write(result[i]);
        }
        if (cycle)
        {
            Console.WriteLine(")");
        }
        else
        {
            Console.WriteLine();
        }

    }
}
