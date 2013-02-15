using System;

class Palindroms
{
    static bool IsPalindrome(string word)
    {
        int wordLength = word.Length;
        for (int i = 0; i < wordLength / 2; i++)
        {
            if (word[i] != word[wordLength - i - 1])
            {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        string str = "checking if a word abba is a lamal palindrome";
        string[] words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (IsPalindrome(words[i]))
            {
                Console.WriteLine(words[i]);
            }
        }


    }
}

