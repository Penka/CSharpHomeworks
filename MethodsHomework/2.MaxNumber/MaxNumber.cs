using System;
using System.Collections.Generic;
class MaxNumber
{
    /*Write a method GetMax() with two parameters that returns the bigger of two integers. 
     * Write a program that reads 3 integers from the console 
     * and prints the biggest of them using the method GetMax().
*/

    static int Max(int a, int b)
    {
        return Math.Max(a, b);
    }

    static void Main(string[] args)
    {
        int n = 3;
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int max = numbers[0];
        for (int i = 0; i < n - 1; i++)
        {
            int currentMax = Max(numbers[i], numbers[i + 1]);
            if (max < currentMax)
            {
                max = currentMax;
            }
        }
            Console.WriteLine("Max is {0}", max);
    }
}
