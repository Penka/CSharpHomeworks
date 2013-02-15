using System;
using System.Collections.Generic;
class IndexesOfAWord
{
    static void Main(string[] args)
    {
        //the input is always correct
        string input = Console.ReadLine();
        input = input.ToUpper();

        int lettersCount = 26;
        List<char> letters = new List<char>();
        for (int i = 0; i < lettersCount; i++)
        {
            letters.Add((char)(i + 65));
        }
        
        int stringLength = input.Length;
        for (int i = 0; i < stringLength; i++)
        {
            Console.Write(letters.IndexOf(input[i]) + " ");
        }
        Console.WriteLine();

    }
}

