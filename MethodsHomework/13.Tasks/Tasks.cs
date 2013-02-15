using System;
using System.Collections.Generic;
class Tasks
{
    static void ReverseNum()
    {
        Console.Write("Enter number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Negative number!");
            return;
        }
        char[] digits = number.ToString().ToCharArray();
        Array.Reverse(digits);
        string output = new string(digits);
        Console.WriteLine(output);

    }

    static void SolveEquation()
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("a must be != 0");
            return;
        }
        double x = (-1.0) * b / a;
        Console.WriteLine(x);
    }

    static void Average()
    {
        Console.Write("Enter sequence length: ");
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine("The length must be > 0");
            return;
        }
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        double average = 0.0;
        for (int i = 0; i < n; i++)
        {
            average = average + numbers[i];
        }
        average = 1.0 * average / n;
        Console.WriteLine("Average is {0}",average);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter task for solve: 1 for reverse, 2 for average and 3 for the equation ");
        int task = int.Parse(Console.ReadLine());
        if (task == 1)
        {
            ReverseNum();
        }
        else if (task == 2)
        {
            Average();
        }
        else if (task == 3)
        {
            SolveEquation();
        }
        else
        {
            Console.WriteLine("Wrog input!");
            return;
        }
    }
}
