using System;
using System.Collections.Generic;
class MinMaxAverageProduct
{
    static int? Max(params int[] numbers)
    {
        if (numbers.Length <= 0)
        {
            return null;
        }
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static int? Min(params int[] numbers)
    {
        if (numbers.Length <= 0)
        {
            return null;
        }
        int min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static int? Sum(params int[] numbers)
    {
        if (numbers.Length <= 0)
        {
            return null;
        }
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }


    static double? Average(params int[] numbers)
    {
        if (numbers.Length <= 0)
        {
            return null;
        }
        double average = ((double)Sum(numbers)) / numbers.Length;
        return average;
    }

    static int? Product(params int[] numbers)
    {
        if (numbers.Length <= 0)
        {
            return null;
        }
        int product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        
        return product;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Max(1, 2, 6, 3));
        Console.WriteLine(Max() == null);

        Console.WriteLine(Min(1, 2, 6, 0, 3));
        Console.WriteLine(Min() == null);

        Console.WriteLine(Sum(1, 2, 6, 3));
        Console.WriteLine(Sum() == null);

        Console.WriteLine(Average(1, 2, 6, 0, 3));
        Console.WriteLine(Average() == null);

        Console.WriteLine(Product(1, 2, 6, 3));
        Console.WriteLine(Product() == null);
    }
}

