using System;
using System.Collections.Generic;
class SubstractAndMultiply
{

    static List<int> Substract(List<int> firstPolynom, List<int> secondPolynom)
    {
        int firstCount = firstPolynom.Count;
        int secondCount = secondPolynom.Count;
        int length = Math.Min(firstCount, secondCount);

        List<int> result = new List<int>();
        for (int i = 0; i < length; i++)
        {
            result.Add(firstPolynom[i] - secondPolynom[i]);
        }
        if (firstCount > secondCount)
        {
            for (int i = length; i < firstCount; i++)
            {
                result.Add(firstPolynom[i]);
            }
        }
        else
        {
            for (int i = length; i < secondCount; i++)
            {
                result.Add(-secondPolynom[i]);
            }
        }
        return result;

    }

    static List<int> Multiply(List<int> firstPolynom, List<int> secondPolynom)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < firstPolynom.Count + secondPolynom.Count - 1; i++)
        {
            result.Add(0);
        }

        for (int i = 0; i < firstPolynom.Count; i++)
        {
            for (int j = 0; j < secondPolynom.Count; j++)
            {
                result[i + j] += firstPolynom[i] * secondPolynom[j];
            }
        }
        return result;
    }

    static void PrintList(List<int> list)
    {
        foreach (var l in list)
        {
            Console.Write(l + " ");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        /*Console.Write("First Degree = ");
        int firstDegree = int.Parse(Console.ReadLine());
        List<int> firstPolynom = new List<int>();
        for (int i = 0; i < firstDegree + 1; i++)
        {
            Console.Write("Coef {0} = ", i);
            firstPolynom.Add(int.Parse(Console.ReadLine()));
        }
        Console.Write("Second Degree = ");
        int secondDegree = int.Parse(Console.ReadLine());
        List<int> secondPolynom = new List<int>();
        for (int i = 0; i < secondDegree + 1; i++)
        {
            Console.Write("Coef {0} = ", i);
            secondPolynom.Add(int.Parse(Console.ReadLine()));
        }*/

        List<int> firstPolynom = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> secondPolynom = new List<int>() { 10, 12, 3, 7, 5, 6 };
        Console.WriteLine("First polynom");
        PrintList(firstPolynom);

        Console.WriteLine("\nSecond polynom");
        PrintList(secondPolynom);

        List<int> result = new List<int>();
        result = Substract(firstPolynom, secondPolynom);
        Console.WriteLine("\nSubstract");
        PrintList(result);

        Console.WriteLine("\nMultiply");
        List<int> multiply = new List<int>();
        multiply = Multiply(firstPolynom, secondPolynom);
        PrintList(multiply);
    }
}
