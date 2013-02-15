using System;
using System.Collections.Generic;

class DifferentWords
{
    static void Main(string[] args)
    {
        string input = "ababa abc abc csharp abc csharp css ababa";
        string[] words = input.Split(' ');
        Dictionary<string, int> wordsCount = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (wordsCount.ContainsKey(word))
            {
                wordsCount[word]++;
            }
            else
            {
                wordsCount.Add(word, 1);
            }
        }
        foreach (KeyValuePair<string, int> word in wordsCount)
        {
            Console.WriteLine("Word {0} - {1} times", word.Key, word.Value);
        }

    }

}
