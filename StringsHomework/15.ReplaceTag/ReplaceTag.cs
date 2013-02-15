using System;

class ReplaceTag
{
    static void Main(string[] args)
    {
        string str = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string openingTagStart = "<a href=\"";
        string openingTagEnd = "\">";
        string closingTag = "</a>";

        string relpaceOpeningTagStart = "[URL=";
        string replaceOpeningTagEnd = "]";
        string replaceClosingTag = "[/URL]";

        str = str.Replace(openingTagStart, relpaceOpeningTagStart);
        str = str.Replace(openingTagEnd, replaceOpeningTagEnd);
        str = str.Replace(closingTag, replaceClosingTag);
        Console.WriteLine(str);
    }
}

