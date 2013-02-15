using System;

class DifferentLettersInString
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        str = str.ToLower(); //case-insensitive

        int[] letters = new int['z' - 'a' + 1];
      
        for (int i = 0; i < str.Length; i++)
        {
            int index = str[i] - 'a';
            letters[index]++;
        }

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] != 0)
            {
                Console.WriteLine("Letter {0} - {1} times", (char)(i + 'a'), letters[i]);
            }
        }
    }
}

