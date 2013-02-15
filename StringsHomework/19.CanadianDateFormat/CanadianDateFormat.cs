using System;
using System.Globalization;
using System.Text.RegularExpressions;

class CanadianDateFormat
{
    static void Main(string[] args)
    {
        string input = "random text 01.02.2013 more random text";
        DateTime date;
        MatchCollection matches = Regex.Matches(input, @"\b\d{2}.\d{2}.\d{4}\b");

        foreach (Match match in matches)
        {
            date = DateTime.ParseExact(match.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
        }
    }
}
