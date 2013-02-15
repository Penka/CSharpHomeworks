using System;
using System.Globalization;
using System.Text;

class CalculateDate
{
    static void Main(string[] args)
    {
        string d = "31.01.2013 12:10:06";
        DateTime date = DateTime.ParseExact(d, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        date = date.AddHours(6.5);

        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine(date);
        Console.WriteLine(date.ToString("dddd", CultureInfo.GetCultureInfo("bg-BG")));
    }
}