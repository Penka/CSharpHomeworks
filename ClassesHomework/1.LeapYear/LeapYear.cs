using System;
using System.Collections.Generic;
class LeapYear
{
    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine("Leap year? {0}", isLeap);
    }
}

