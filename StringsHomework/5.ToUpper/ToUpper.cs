using System;
using System.Text;

class ToUpper
{
    static string UpCase(string str)
    {
        StringBuilder sb = new StringBuilder();
        string openingTag = "<upcase>";
        string closingTag = @"</upcase>";

        int strLength = str.Length;
        int startIndex = -1;
        int endIndex = -1;
        int currentPosition = 0;
        while ((startIndex = str.IndexOf(openingTag, startIndex + 1)) != -1)
        {
            sb.Append(str.Substring(currentPosition, startIndex - currentPosition));
            currentPosition = startIndex + openingTag.Length;
            endIndex = str.IndexOf(closingTag, endIndex + 1);
            sb.Append(str.Substring(currentPosition, endIndex - startIndex - openingTag.Length).ToUpper());
            currentPosition = endIndex + closingTag.Length;
        }
        sb.Append(str.Substring(currentPosition, strLength - currentPosition));
        return sb.ToString();
    }
    static void Main(string[] args)
    {
        string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(UpCase(str));

    }
}

