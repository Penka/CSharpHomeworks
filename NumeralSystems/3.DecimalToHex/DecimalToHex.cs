using System;
using System.Collections.Generic;
class DecimalToHex
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

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        //string toBinary = Convert.ToString(number, 16);
        string toBinary = "";
        int remainder;
        while (number > 0)
        {
            remainder = number % 16;
            if (remainder >= 10)
            {
                char letter = (char)('A' + remainder % 10);
                toBinary += letter.ToString();
            }
            else
            {
                toBinary += remainder.ToString();
            }
            number = number / 16;
        }
        toBinary = Reverse(toBinary);
        Console.WriteLine(toBinary);
    }
}

