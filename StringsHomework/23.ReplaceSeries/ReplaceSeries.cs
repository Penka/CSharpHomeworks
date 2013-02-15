using System;
using System.Text;

class ReplaceSeries
{
    static void Main(string[] args)
    {
        string input = "aaaaabbbbbcdddeeeedssaa"; 
        StringBuilder sb = new StringBuilder();

        sb.Append(input[0]);
        int index = 0;
        int currentIndex = 1;
        while (currentIndex < input.Length)
        {
            if (input[index] != input[currentIndex])
            {
                index = currentIndex;
                sb.Append(input[currentIndex]);
            }
            currentIndex++;
        }

        Console.WriteLine(sb.ToString());
    }
}