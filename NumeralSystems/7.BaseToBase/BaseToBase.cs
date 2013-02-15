using System;
using System.Collections.Generic;
class BaseToBase
{
    static string Reverse(string str)
    {
        string reversed = "";
        for (int i = 0; i < str.Length; i++)
        {
            reversed = reversed + str[str.Length - 1 - i].ToString();
        }
        return reversed;
    }

    static int ToDecimal(string str, int s) //we have string in d-base and convert it to int number
    {
        int result = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] < '9')
            {
                result += (str[i] - '0') * (int)Math.Pow(s, str.Length - i - 1);
            }
            else
            {
                result += (str[i] - 'A' + 10) * (int)Math.Pow(s, str.Length - i - 1);
            }
        }
        return result;
    }

    static string ToBase(int number, int d) //we have decimal number and convert it to string - base s
    {
        string result = "";
        while (number != 0)
        {
            int r = number % d;
            if (r > 9)
            {
                char a = (char)('A' + (r % 10));
                result += a.ToString();
            }
            else
            {
                result += r.ToString();
            }
            number = number / d;
        }
        result = Reverse(result);
        return result;
    }
    

    static void Main(string[] args)
    {
        Console.Write("Base from: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Base to: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter string in base {0} ", s);
        string input = Console.ReadLine();
        int n = ToDecimal(input, s);
        string output = ToBase(n, d);
        Console.WriteLine(output);
    }
}

