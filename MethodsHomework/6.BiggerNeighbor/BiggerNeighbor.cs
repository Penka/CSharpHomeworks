using System;
using System.Collections.Generic;
class BiggerNeighbor
{
    /*Write a method that returns the index of the first element
     * in array that is bigger than its neighbors, or -1, 
     * if there’s no such element.
Use the method from the previous exercise.*/
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
        int index = -1;
        for (int i = 0; i < n; i++)
        {
            bool bigger = BiggerThanNeighbors(numbers, i);
            if (bigger)
            {
                index = i;
                break;
            }
        }
        Console.WriteLine(index);
    }
}

