using System;
using System.Globalization;

class CountSubstring
{
    static void Main(string[] args)
    {
        string text = @"We are living in an yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        string substring = "in";

        text = text.ToLower();

        int index = -1;
        int count = 0;
        while ((index = CultureInfo.CurrentUICulture.CompareInfo.IndexOf(text, substring, index + 1, CompareOptions.IgnoreCase)) != -1)
        {
            count++;
        }
        Console.WriteLine(count);
    }
}

