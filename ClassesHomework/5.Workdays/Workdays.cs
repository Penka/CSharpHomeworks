using System;
using System.Collections.Generic;
class Workdays
{
    static DateTime[] holidays = {new DateTime(2013, 1, 1),
                               new DateTime(2013, 3, 3),
                               new DateTime(2013, 5, 6),
                               new DateTime(2013, 5, 24),
                               new DateTime(2013, 12, 24),
                               new DateTime(2013, 12, 25),
                               new DateTime(2013, 12, 26),
                               new DateTime(2013, 12, 31),};
    static bool IsHoliday(DateTime day)
    {
        foreach (var holiday in holidays)
        {
            if (DateTime.Compare(day, holiday) == 0)
            {
                return true;
            }
        }
        return false;
    }

    static int WorkDays(DateTime start, DateTime end)
    {
        if (DateTime.Compare(start, end) > 0)
        {
            return WorkDays(end, start);
        }
        int count = 0;
        for (DateTime day= start; day <= end; day = day.AddDays(1))
        {
            if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday || IsHoliday(day))
            {
                continue;
            }
            count++;
        }
        return count;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());

        DateTime start = DateTime.Today;
        DateTime end = new DateTime(year, month, day);

        int workdays = WorkDays(start, end);
        Console.WriteLine(workdays);
    }
}
