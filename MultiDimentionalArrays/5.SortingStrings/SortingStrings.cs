using System;
using System.Collections.Generic;

class SortingStrings
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            words.Add(input);
        }

        words.Sort((x, y) => x.Length.CompareTo(y.Length));
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}

