using System;
using System.Text.RegularExpressions;

class SecretLanguage
{

    static int CostOfWord(string word, string codeWord)
    {
        int cost = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] != codeWord[i])
            {
                cost++;
            }
        }
        return cost;
    }

    static bool AreSameWords(string codeWord, string word)
    {
        char[] codeWordChars = codeWord.ToCharArray();
        char[] wordChars = word.ToCharArray();
        Array.Sort(codeWordChars);
        Array.Sort(wordChars);
        codeWord = new string(codeWordChars);
        word = new string(wordChars);
        return codeWord == word;
    }


    static int MinCostOfCodeWords(MatchCollection matches, string code)
    {
        int[] results = new int[code.Length + 1];

        for (int i = 1; i <= code.Length; i++)
        {
            results[i] = -1;
            for (int j = 0; j < matches.Count; j++)
            {
                Match match = matches[j];
                if (match.Length > i)
                {
                    continue;
                }
             
                if (results[i - match.Length] == -1)
                {
                    continue;
                }
                string currentWord = code.Substring(i - match.Length, match.Length);
                if(!AreSameWords(currentWord, match.ToString()))
                {
                    continue;
                }
                
                int currentResult = CostOfWord(currentWord, match.ToString()) + results[i - match.Length];
                if (results[i] == -1)
                {
                    results[i] = currentResult;
                }
                else
                {
                    results[i] = Math.Min(results[i], currentResult);
                }
            }

        }

        return results[code.Length];
    }

    static void Main(string[] args)
    {
        string code = Console.ReadLine();
        string s = Console.ReadLine();
        MatchCollection matches = Regex.Matches(s, @"\w+");
        int minMatchCount = MinCostOfCodeWords(matches, code);
        Console.WriteLine(minMatchCount);

    }
}

