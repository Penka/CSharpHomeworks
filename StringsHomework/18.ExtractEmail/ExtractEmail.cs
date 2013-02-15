using System;
using System.Text.RegularExpressions;

class ExtractEmail
{
    static void Main(string[] args)
    {
        string email = "academy@telerik.com some other random text academy@telerik.com even more random text";

        Regex regex = new Regex(@"\w+@\w+\.\w+");
        MatchCollection matches = regex.Matches(email);
        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }

    }
}

