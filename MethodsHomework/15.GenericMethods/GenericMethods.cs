using System;
using System.Collections.Generic;
class GenericMethods
{
    static T Max<T>(params T[] numbers) where T : IComparable
    {
        if (numbers.Length <= 0)
        {
            return default(T);
        }
        T max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max.CompareTo(numbers[i]) < 0)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static T Min<T>(params T[] numbers) where T : IComparable
    {
        if (numbers.Length <= 0)
        {
            return default(T);
        }
        T min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (min.CompareTo(numbers[i]) > 0)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static T Sum<T>(params T[] numbers)
    {
        if (numbers.Length <= 0)
        {
            return default(T);
        }
        dynamic sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }


    static double Average<T>(params T[] numbers)
    {
        if (numbers.Length <= 0)
        {
            return Convert.ToDouble(default(T));
        }
        double average = Convert.ToDouble((dynamic) Sum(numbers) )/numbers.Length;
        return average;
    }

    static T Product<T>(params T[] numbers)
    {
        if (numbers.Length <= 0)
        {
            return default(T);
        }
        dynamic product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }

        return product;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Max : " + Max(1, 2, 6, 3));

        Console.WriteLine("Min: " + Min(1, 2, 6, 0, 3));

        Console.WriteLine("Sum: " + Sum(1, 2, 6, 3));

        Console.WriteLine("Average: " + Average(1, 2, 6, 0, 3));

        Console.WriteLine("Product: " + Product(1, 2, 6, 3));
    }
}

