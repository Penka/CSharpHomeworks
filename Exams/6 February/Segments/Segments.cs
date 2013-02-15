using System;
using System.Collections.Generic;
using System.Text;

class Segments
{
    static string[] digits =
        new string[] { "1111110", "0110000", "1101101", "1111001", "0110011", 
            "1011011", "1011111", "1110000","1111111" , "1111011"};

    static List<List<int>> solutions = new List<List<int>>();

    static void Print(int listIndex, string str)
    {
        if (listIndex >= solutions.Count)
        {
            Console.WriteLine(str);
            return;
        }
        foreach (int number in solutions[listIndex])
        {
            //Console.Write(number);
            Print(listIndex + 1, str + number.ToString());
        }
    }

    static bool Matches(string str, string digit)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == digit[i])
            {
                continue;
            }
            if (str[i] == '0' && digit[i] == '1')
            {
                continue;
            }
            return false;
        }
        return true;
    }

    static List<int> SolveMe(string str)
    {
        List<int> matchungNumbers = new List<int>();
        for (int i = 0; i < digits.Length; i++)
        {
            if (Matches(str, digits[i]))
            {
                matchungNumbers.Add(i);
            }
        }
        return matchungNumbers;
    }

    static void GenerateDigits(string[] seq)
    {
        for (int i = 0; i < seq.Length; i++)
        {
            List<int> l = SolveMe(seq[i]);
            solutions.Add(l);
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] seq = new string[n];
        List<List<int>> zeroIndexes = new List<List<int>>();
        List<List<bool>> used = new List<List<bool>>();
        for (int i = 0; i < n; i++)
        {
            seq[i] = Console.ReadLine();
        }

        GenerateDigits(seq);

        int count = 1;
        for (int i = 0; i < solutions.Count; i++)
        {
            count *= solutions[i].Count;
        }
        Console.WriteLine(count);
        Print(0, "");
        
    }
}
