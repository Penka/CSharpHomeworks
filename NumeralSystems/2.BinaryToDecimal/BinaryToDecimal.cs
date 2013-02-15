using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string binary = "10010";
        int number = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            int bit = int.Parse(binary[binary.Length -i - 1].ToString());
            number = number + (int)Math.Pow(2, i) * bit;
        }
        //int number = Convert.ToInt32(binary, 2);
        Console.WriteLine(number);
    }
}

