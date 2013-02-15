using System;
using System.Text;

class ReverseWords
{
    static void Main(string[] args)
    {
        string sequence = "C# is not C++, not PHP and not Delphi!";
        char endSentence = sequence[sequence.Length - 1];
        string[] words = sequence.Split(' ');
        Array.Reverse(words);
        words[0] = words[0].Remove(words[0].Length - 1);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < words.Length - 1; i++)
        {
            sb.Append(words[i] + " ");
        }
        sb.Append(words[words.Length - 1]);
        sb.Append(endSentence);
        Console.WriteLine(sb.ToString());
    }
}

