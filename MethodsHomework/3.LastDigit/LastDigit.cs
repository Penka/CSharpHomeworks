using System;
using System.Collections.Generic;
class LastDigit
{
    /*
     * Write a method that returns the last digit of
     * given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".
*/
    static string LastDigitString(int number)
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int index = number % 10;
        return digits[index];
    }

    static void Main(string[] args)
    {
        Console.Write("Number = ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigitString(number));
    }
}

