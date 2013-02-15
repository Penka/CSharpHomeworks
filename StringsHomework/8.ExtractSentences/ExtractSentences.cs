using System;

class ExtractSentences
{
    static bool IsLetter(char ch)
    {
       // Console.WriteLine("char is {0}", ch);
        if ((ch >= 'A' && ch <= 'A' + 25) || (ch >= 'a' && ch <= 'a' + 25))
        {
           // Console.WriteLine("here?");
            return true;
        }
        return false;
    }

    static bool PreviousCharIsNonLetterSymbol(string str, int index)
    {
        //Console.WriteLine("previous " + index + "    " + str);
        if (index - 1 < 0)
        {
           // Console.WriteLine("true??");
            return true;
        }
        if (IsLetter(str[index - 1]))
        {
            return false;
        }
        //Console.WriteLine("true??");
        return true;
    }

    static bool NextCharIsNonLetterSymbol(string str, int index)
    {
        //Console.WriteLine("next " + index + "    " + str);
        if (index + 1>= str.Length)
        {
            //Console.WriteLine("true??");
            return true;
        }
        if (IsLetter(str[index + 1]))
        {
            return false;
        }
        //Console.WriteLine("true??");
        return true;
    }

    static void Main(string[] args)
    {
        string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string[] sentenceSeparator = new string[] { ". " };
        string[] sequences = str.Split(sentenceSeparator, StringSplitOptions.None);
        string word = "in";
        for (int i = 0; i < sequences.Length - 1; i++)
        {
            sequences[i] = sequences[i] + ".";
        }
        for (int i = 0; i < sequences.Length; i++)
        {
            int index = -1;
            while ((index = sequences[i].IndexOf(word, index + 1)) != -1)
            {
                if (PreviousCharIsNonLetterSymbol(sequences[i], index) && 
                    NextCharIsNonLetterSymbol(sequences[i], index + word.Length - 1))
                {
                    Console.WriteLine(sequences[i]);
                }
            }
        }

    }
}
