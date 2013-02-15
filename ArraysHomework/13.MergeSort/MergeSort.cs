using System;
using System.Collections.Generic;

class MergeSort
{
    static List<int> MyMergeSort(List<int> numbers)
    {
        if (numbers.Count <= 1)
        {
            return numbers;
        }
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        int middle = numbers.Count / 2;
        for (int i = 0; i < middle; i++)
        {
            left.Add(numbers[i]);
        }
        for (int i = middle; i < numbers.Count; i++)
        {
            right.Add(numbers[i]);
        }
        left = MyMergeSort(left);
        right = MyMergeSort(right);
        return MergeLists(left, right);
    }
    static List<int> MergeLists(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();
        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else if(right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }
        return result;
    }

    static void PrintList(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            Console.Write(numbers[i] + ", ");
        }
        Console.WriteLine(numbers[numbers.Count - 1]);
    }

    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>(n);
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        PrintList(numbers);
        
        List<int> sorted = new List<int>();
        sorted = MyMergeSort(numbers);
        Console.WriteLine("sorted");
        PrintList(sorted);

    }
}
