using System;

class SortingListOfWords
{
    static void Main(string[] args)
    {
        string input = "abc csharp css .net clr";
        string[] words = input.Split(' ');

        Array.Sort(words);

        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}

