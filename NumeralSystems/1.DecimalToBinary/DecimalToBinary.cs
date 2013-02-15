using System;
using System.Collections.Generic;
class DecimalToBinary
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
        //string toBinary = Convert.ToString(number, 2);
        string toBinary = "";
        int remainder;
        while (number > 0)
        {
            remainder = number % 2;
            toBinary += remainder.ToString();
            number = number / 2;
        }
        toBinary = Reverse(toBinary);
        Console.WriteLine(toBinary);
    }
}

