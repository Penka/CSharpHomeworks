using System;
using System.Collections.Generic;
using System.Text;

class DenomeDecoder
{

    static bool IsChar(char ch)
    {
        if (ch >= 'A' && ch <= 'Z')
        {
            return true;
        }
        return false;
    }

    static void PrintRow(StringBuilder sb, int n, int m, int currentIndex)
    {

        for (int i = 0; i < n; i += m)
        {
            int startIndex = currentIndex + i;
            if (startIndex > sb.Length)
            {
                Console.WriteLine();
                return;
            }
            Console.Write(" ");

            int endIndex = 0;
            endIndex = currentIndex % n + i + m;
            if (endIndex > n)
            {
                int len = n % m;
                if (startIndex + len >= sb.Length)
                {
                    len = sb.Length - startIndex;
                }
                Console.Write(sb.ToString(startIndex, len));
            }
            else
            {

                if (startIndex + m >= sb.Length)
                {
                    Console.Write(sb.ToString(startIndex, sb.Length - startIndex));
                }
                else
                {
                    Console.Write(sb.ToString(startIndex, m));
                }
            }

        }
        Console.WriteLine();

    }

    static void PrintAnswer(StringBuilder sb, int n, int m)
    {
        int rowCount = sb.Length / n;
        if (sb.Length % n != 0)
        {
            rowCount++;
        }
        int rowCountDigits = rowCount.ToString().Length;
        int rowNumber = 1;
        for (int i = 0; i < sb.Length; i += n)
        {
            string spaces = new string(' ', rowCountDigits - rowNumber.ToString().Length);
            Console.Write(spaces + rowNumber);
            PrintRow(sb, n, m, i);
            rowNumber++;
        }
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string code = Console.ReadLine();

        string[] str = input.Split(' ');
        int n = int.Parse(str[0]);
        int m = int.Parse(str[1]);
        StringBuilder sb = new StringBuilder();
        StringBuilder number = new StringBuilder();

        for (int j = 0; j < code.Length; j++)
        {
            if (!IsChar(code[j]))
            {
                number.Append(code[j]);
            }
            else
            {
                int num;
                if (number.Length == 0)
                {
                    num = 1;
                }
                else
                {
                    num = int.Parse(number.ToString());
                }
                number.Clear();
                sb.Append(code[j], num);
            }
        }

        PrintAnswer(sb, n, m);
    }
}

