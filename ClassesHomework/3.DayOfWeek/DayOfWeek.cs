using System;
using System.Collections.Generic;
class DayOfWeek
{
    /*Write a program that prints to the console which day of the week is today. Use System.DateTime*/

    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        string currentDay = now.DayOfWeek.ToString();
        Console.WriteLine(currentDay);
        
    }
}

