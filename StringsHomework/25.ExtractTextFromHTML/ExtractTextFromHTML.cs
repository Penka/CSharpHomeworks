using System;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main(string[] args)
    {
        string html = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        MatchCollection matches = Regex.Matches(html, @">(.*?)<");
        foreach (Match match in matches)
        {
            string str = match.ToString();
            str = str.Substring(1, str.Length - 2);
            if (str.Length > 0)
            {
                Console.WriteLine(str);
            }
        }
    }
}
