using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] inputToChars = input.ToCharArray();
        Array.Reverse(inputToChars);
        input = new string(inputToChars);
        Console.WriteLine(input);
    }
}

