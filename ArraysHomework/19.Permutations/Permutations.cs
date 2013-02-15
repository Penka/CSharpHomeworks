using System;
using System.Collections.Generic;
class Permutations
{
    static int FindIndex(int[] numbers)
    {
        int length = numbers.Length;
        int maxIndex = -1;
        for (int i = 0; i < length - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    static int MaxIndex(int start, int[] numbers)
    {
        int max = start + 1;
        for (int i = start + 1; i < numbers.Length; i++)
        {
            if (numbers[start] < numbers[i])
            {
                max = i;
            }
        }
        return max;
    }
    
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.Write("{");

        for (int i = 0; i < n - 1; i++)
        {
            numbers[i] = i + 1;
            Console.Write(numbers[i] + ", ");
        }
        numbers[n - 1] = n;
        Console.WriteLine(n + " }");

        int index = FindIndex(numbers);
        while (index != -1)
        {
            int maxIndex = MaxIndex(index, numbers);
            int tmp = numbers[index];
            numbers[index] = numbers[maxIndex];
            numbers[maxIndex] = tmp;
            Array.Reverse(numbers, index + 1, n - index - 1);
            Console.Write("{");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine(numbers[n - 1] + " }");
            index = FindIndex(numbers);
        }
        

    }
}

