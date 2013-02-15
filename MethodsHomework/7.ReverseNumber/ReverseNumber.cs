using System;
using System.Collections.Generic;
class ReverseNumber
{
    /*static int ReverseNum(int number)
    {
        int reversed = number % 10;
        number = number / 10;
        while (number != 0)
        {
            reversed = (reversed * 10) + (number % 10);
            number = number / 10;
        }
        return reversed;
    }*/

    static void Main(string[] args)
    {
        Console.Write("Number = ");
        decimal number = decimal.Parse(Console.ReadLine());
        char[] digits = number.ToString().ToCharArray();

        if (digits[0] == '-')
        {
            Array.Reverse(digits, 1, digits.Length - 1);
        }
        else
        {
            Array.Reverse(digits);
        }
        string reversed = new string(digits);
        Console.WriteLine("Reversed number is " + reversed);
    }
}

