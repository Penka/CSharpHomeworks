using System;
using System.Collections.Generic;
class BinSearch
{
    /*Write a program, that reads from the console an array of N integers and an integer K,
     * sorts the array and using the method Array.BinSearch() 
     * finds the largest number in the array which is ≤ K. 
*/
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0} = ", i);
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }

        numbers.Sort();
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int index = numbers.BinarySearch(k);
        if (index == 0)
        {
            Console.WriteLine(numbers[index]);
        }
        else if (index > 0)
        {
            index = index - 1;
            Console.WriteLine(numbers[index]);
            
        }
        else if (index == -1)
        {
            Console.WriteLine("There is no element that is <= {0}", k);
        }
        else if(index < -1)
        {
            index = (-1) * index - 2;
            Console.WriteLine(numbers[index]);
            
        }
    }
}

