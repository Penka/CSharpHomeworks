using System;
using System.Collections.Generic;
using System.Text;

class Crossword
{
    static List<string> solutions = new List<string>();

    static void Print(List<string> words, int k, string possibleSolution)
    {
        int count = words.Count;
        if (k == 0)
        {
             if (IsSolution(words, possibleSolution))
             {
            solutions.Add(possibleSolution);
            }
            return;
        }
        for (int i = 0; i < count; i++)
        {

            Print(words, k - 1, possibleSolution + words[i] + " ");
        }

    }

    static string Transponate(string possibleSolution)
    {
        StringBuilder sb = new StringBuilder();
        string[] usedWords = possibleSolution.Split(' ');

        for (int i = 0; i < usedWords[0].Length; i++)
        {
            for (int j = 0; j < usedWords.Length - 1; j++)
            {
                sb.Append(usedWords[j][i]);
            }
            sb.Append(" ");
        }
        return sb.ToString();
    }
    private static bool IsSolution(List<string> words, string possibleSolution)
    {
        string str = Transponate(possibleSolution);
        int count = 0;
        string[] usedWords = str.Split(' ');
        for (int i = 0; i < usedWords.Length; i++)
        {
            for (int j = 0; j < words.Count; j++)
            {
                if (usedWords[i] == words[j])
                {
                    count++;
                }
            }
        }
        return count >= (words.Count / 2);
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<string> words = new List<string>(2 * n);
        for (int i = 0; i < 2 * n; i++)
        {
            words.Add(Console.ReadLine());
        }
        Print(words, n, "");
        if (solutions.Count == 0)
        {
            Console.WriteLine("NO SOLUTION!");
            return;
        }
        string firstCrossword = solutions[0];
        for (int i = 1; i < solutions.Count; i++)
        {
            if (string.Compare(firstCrossword, solutions[i]) > 0)
            {
                firstCrossword = solutions[i];
            }
        }
        string[] result = firstCrossword.Split(' ');
        for (int i = 0; i < result.Length - 1; i++)
        {
            Console.WriteLine(result[i]);
        }

    }
}

