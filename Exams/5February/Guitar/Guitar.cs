using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Guitar
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int initialState = int.Parse(Console.ReadLine());
        int maxLevel = int.Parse(Console.ReadLine());
        string[] separator = new string[] { ", " };
        string[] intervalsString = input.Split(separator, StringSplitOptions.None);
        int[] changes = new int[intervalsString.Length];
        for (int i = 0; i < intervalsString.Length; i++)
        {
            changes[i] = int.Parse(intervalsString[i]);
        }
        bool[] range = new bool[maxLevel + 1];
        range[initialState] = true;
        for (int i = 0; i < changes.Length; i++)
        {
            range = MakeChange(changes[i], range);
        }
        
        for (int i = range.Length - 1; i >= 0; i--)
        {
            if (range[i])
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine(-1);
    }
  
    private static bool[] MakeChange(int changes, bool[] range)
    {
        bool[] result = new bool[range.Length];
        for (int i = 0; i < range.Length; i++)
        {
            if (!range[i])
            {
                continue;
            }
            if (i - changes >= 0)
            {
                result[i - changes] = true;
            }
            if (i + changes < result.Length)
            {
                result[i + changes] = true;
            }
        }
        return result;
    }
}

