using System;
class SelectionSort
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0}: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int minNumber = numbers[0];
        int minIndex;
        for (int i = 0; i < n; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                int tmp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = tmp;
            }
        }

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
            
        }
        Console.WriteLine();
    }
}

