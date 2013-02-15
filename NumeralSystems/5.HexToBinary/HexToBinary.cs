using System;
using System.Collections.Generic;
class HexToBinary
{
    static string Reverse(string str)
    {
        string reversed = "";
        for (int i = 0; i < str.Length; i++)
        {
            reversed = reversed + str[str.Length - 1 - i].ToString();
        }
        return reversed;
    }

    static void Main(string[] args)
    {
        string hex = "AB12";
        string binary = "";
        for (int i = 0; i < hex.Length; i++)
        {
            int n;
            if (hex[i] < '9')
            {
                n = hex[i] - '0';
            }
            else
            {
                n = hex[i] - 'A' + 10; ;
            }
            string bin = "";
            for (int j = 0; j < 4; j++)
            {
                bin = bin + n % 2;
                n = n / 2;
            }
            bin = Reverse(bin);
            binary += bin + " ";
        }
        Console.WriteLine(binary);
    }
}
