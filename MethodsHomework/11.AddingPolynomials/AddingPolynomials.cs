using System;
using System.Collections.Generic;
class AddingPolynomials
{

    /*Write a method that adds two polynomials. 
*/
    static List<int> Sum(List<int> firstPolynom, List<int> secondPolynom)
    {
        int firstCount = firstPolynom.Count;
        int secondCount = secondPolynom.Count;
        if (secondCount < firstCount)
        {
            return Sum(secondPolynom, firstPolynom);
        }
        List<int> result = new List<int>(secondCount);
        for (int i = 0; i < firstCount; i++)
        {
            result.Add(firstPolynom[i] + secondPolynom[i]);
        }
        for (int i = firstCount; i < secondCount; i++)
        {
            result.Add(secondPolynom[i]);
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
        List<int> secondPolynom = new List<int>() { 1, 2, 3, 4, 5 };
        Console.WriteLine("first");
        PrintList(firstPolynom);
        Console.WriteLine("second");
        PrintList(secondPolynom);
        List<int> result = new List<int>();
        result = Sum(firstPolynom, secondPolynom);
        PrintList(result);

    }
}
