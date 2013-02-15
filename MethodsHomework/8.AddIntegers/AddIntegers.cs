using System;
using System.Collections.Generic;
class AddIntegers
{
    static List<char> ToChars(int number)
    {
        string str = number.ToString();
        List<char> result = new List<char>();
        for (int i = 0; i < str.Length; i++)
        {
            result.Add(str[i]);
        }
        result.Reverse();
        return result;
    }

    static List<char> SumCharArrays(List<char> a, List<char> b)
    {
        int aCount = a.Count;
        int bCount = b.Count;
        if (bCount < aCount)
        {
            return SumCharArrays(b, a);
        }
        List<char> result = new List<char>();

        int plus = 0;
        for (int i = 0; i < aCount; i++)
        {
            int sum = a[i] - '0' + b[i] - '0' + plus;
            result.Add((char)(sum % 10 + '0'));
            plus = sum / 10;
        }
        for (int i = aCount; i < bCount; i++)
        {
            int sum = b[i] - '0' + plus;
            result.Add((char)(sum % 10 + '0'));
            plus = sum / 10;
        }
        if (plus > 0)
        {
            result.Add((char)(plus + '0'));
        }
        result.Reverse();
        return result;
    }


    static void Main(string[] args)
    {
        int a = 993;
        int b = 123;
        int c = 1;
        List<char> res = new List<char>();
        res = SumCharArrays(ToChars(a), ToChars(b));
        for (int i = 0; i < res.Count; i++)
        {
            Console.Write(res[i].ToString());
        }
        Console.WriteLine();
        res = SumCharArrays(ToChars(a), ToChars(c));
        for (int i = 0; i < res.Count; i++)
        {
            Console.Write(res[i].ToString());
        }
        Console.WriteLine();
    }
}

