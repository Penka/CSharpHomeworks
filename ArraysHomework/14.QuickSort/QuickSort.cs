using System;
using System.Collections.Generic;
class QuickSort
{
    static List<int> MyQuickSort(List<int> numbers)
    {
        if (numbers.Count <= 1)
        {
            return numbers;
        }
        int pivot = numbers.Count / 2;
        int numberPivot = numbers[pivot];
        numbers.RemoveAt(pivot);
        List<int> less = new List<int>();
        List<int> greater = new List<int>();
        foreach (int number in numbers)
        {
            if (number <= numberPivot)
            {
                less.Add(number);
            }
            else
            {
                greater.Add(number);
            }
        }
        List<int> result = new List<int>();
        result.AddRange(MyQuickSort(less));
        result.Add(numberPivot);
        result.AddRange(MyQuickSort(greater));
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
        List<int> numbers = new List<int>() { 1, 2, 10, 20, 5, 4, 7, 19 };
        PrintList(numbers);
        List<int> sorted = new List<int>();
        sorted = MyQuickSort(numbers);
        PrintList(sorted);

    }
}

