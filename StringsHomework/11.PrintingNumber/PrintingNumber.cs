using System;

class PrintingNumber
{
    static void Main(string[] args)
    {
        int number = 245;

        Console.WriteLine("{0,15}", number);
        Console.WriteLine("{0,15:X}", number);
        Console.WriteLine("{0,15:P}", number);
        Console.WriteLine("{0,15:E}", number);
    }
}

