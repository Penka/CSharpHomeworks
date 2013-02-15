using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string hex = "36C";
        int number = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            int bit;
            if(!int.TryParse(hex[hex.Length - i - 1].ToString(), out bit))
            {
                bit = hex[hex.Length - i - 1] - 'A' + 10;
            }
            number = number + (int)Math.Pow(16, i) * bit;
        }
        //int number = Convert.ToInt32(hex, 16);
        Console.WriteLine(number);
    }
}

