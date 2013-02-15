using System;

class ReplaceForbiddenWords
{
    static void Main(string[] args)
    {
        string str = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = new string[] { "PHP", "CLR", "Microsoft" };
        foreach (string word in forbiddenWords)
        {
            string asterisks = new string('*', word.Length);
            str = str.Replace(word, asterisks);
        }
        Console.WriteLine(str);
    }
}

