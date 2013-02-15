using System;
using System.Collections.Generic;
class Greetings
{

    static void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static void Main(string[] args)
    {
        Console.Write("Enter you name: ");
        string name = Console.ReadLine();
        SayHello(name);
    }
}

