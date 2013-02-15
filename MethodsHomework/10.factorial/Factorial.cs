using System;
using System.Collections.Generic;
class Factorial
{
    /*Write a program to calculate n! 
     * for each n in the range [1..100]. 
     * Hint: Implement first a method that multiplies a 
     * number represented as array of digits by given integer number. 
*/
    static void Print(List<char> a)
    {
        for (int i = 0; i < a.Count; i++)
        {
            Console.Write(a[i].ToString());
        }
        Console.WriteLine();
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
            int sum = a[aCount - 1- i] - '0' + b[bCount - i - 1] - '0' + plus;
            result.Add((char)(sum % 10 + '0'));
            plus = sum / 10;
        }
        for (int i = bCount - aCount - 1; i >= 0; i--)
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

    static List<char> Multiply(List<char> a, int n)
    {
        List<char> result = new List<char>() {'0'};
        for (int i = 0; i < n; i++)
        {
            result = SumCharArrays(result, a);
        }
        return result;
    }

    static void Main(string[] args)
    {
        List<char> factorial = new List<char>() {'1'};
        for (int i = 1; i <= 100; i++)
        {
            factorial = Multiply(factorial, i);
            Print(factorial);
        }
        
    }
}

