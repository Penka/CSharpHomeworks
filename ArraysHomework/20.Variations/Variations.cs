using System;
using System.Collections.Generic;
class Variations
{
    static void Print(List<int> numbers, int k, string output)
    {
        int count = numbers.Count;
        if (k == 0)
        {
            Console.WriteLine(output);
            return;
        }
        for (int i = 0; i < count; i++)
        {
            List<int> sublist = new List<int>();
            sublist.AddRange(numbers);
            sublist.Remove(numbers[i]);
            Print(sublist, k - 1, output + numbers[i] + " ");
        }

    }
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>(n);
        for (int i = 0; i < n; i++)
        {
            numbers.Add(i + 1);
        }
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        Print(numbers, k, "");
    }
}
