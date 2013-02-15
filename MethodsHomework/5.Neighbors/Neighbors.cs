using System;
using System.Collections.Generic;

class Neighbors
{
    static bool BiggerThanNeighbors(int[] numbers, int index)
    {
        if (index <= 0 || index >= numbers.Length - 1) //only one neighbor
        {
            return false;
        }
        return numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1];
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
        Console.Write("Index = ");
        int index = int.Parse(Console.ReadLine());

        bool bigger = BiggerThanNeighbors(numbers, index);
        Console.WriteLine(bigger);

    }
}
