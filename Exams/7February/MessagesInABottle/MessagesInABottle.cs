using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class MessagesInABottle
{
    static List<string> possibleDecodedMessages = new List<string>();

    static void GeneratePossibleMessages(string code, Dictionary<string, string> dict, string messageSoFar)
    {
        if (code.Length == 0)
        {
            possibleDecodedMessages.Add(messageSoFar);
            return;
        }
        foreach (KeyValuePair<string, string> pair in dict)
        {
            if (code.StartsWith(pair.Key.ToString()))
            {
                GeneratePossibleMessages(code.Substring(pair.Key.ToString().Length), dict, messageSoFar + pair.Value);
            }
        }
    }


    static bool IsLetter(char ch)
    {
        if (ch >= 'A' && ch <= 'Z')
        {
            return true;
        }
        return false;
    }
    static Dictionary<string, string> GenerateDictionary(string cipher)
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();

        MatchCollection matches = Regex.Matches(cipher, @"(\D)(\d+)");

        foreach (Match match in matches)
        {
            string key = match.Groups[2].Value;
            string value = match.Groups[1].Value;
            dict.Add(key, value);
        }
        return dict;

    }
    static void Main(string[] args)
    {
        string code = Console.ReadLine();
        string cipher = Console.ReadLine();

        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict = GenerateDictionary(cipher);

        GeneratePossibleMessages(code, dict, "");

        possibleDecodedMessages.Sort();
        Console.WriteLine(possibleDecodedMessages.Count);
        for (int i = 0; i < possibleDecodedMessages.Count; i++)
        {
            Console.WriteLine(possibleDecodedMessages[i]);
        }

    }
}
