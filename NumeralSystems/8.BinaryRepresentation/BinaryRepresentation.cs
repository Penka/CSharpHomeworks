using System;
using System.Collections.Generic;
class BinaryRepresentation
{
    static void Main(string[] args)
    {
        short n = short.Parse(Console.ReadLine());
        string binary = Convert.ToString(n, 2);
        if (n >= 0)
        {
            string zeros = new string('0', 16 - binary.Length);
            binary = zeros + binary;
        }
        Console.WriteLine(binary);
    }
}
