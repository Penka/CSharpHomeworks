using System;

class DaysBetweenDates
{
    static void Main(string[] args)
    {
        string date1 = "27.02.2006";
        string date2 = "3.03.2016";

        string[] d1 = date1.Split('.');
        string[] d2 = date2.Split('.');

        int day1 = int.Parse(d1[0]);
        int month1 = int.Parse(d1[1]);
        int year1 = int.Parse(d1[2]);

        int day2 = int.Parse(d2[0]);
        int month2 = int.Parse(d2[1]);
        int year2 = int.Parse(d2[2]);

        DateTime firstDate = new DateTime(year1, month1, day1);
        DateTime secondDate = new DateTime(year2, month2, day2);

        System.TimeSpan distance = secondDate.Subtract(firstDate);
        int distanceIndex = distance.ToString().IndexOf('.');
        string dist = distance.ToString().Substring(0, distanceIndex);
        Console.WriteLine(dist);
    }

}
