using System;
class ArrayOfTwentyElements
{
    static void Main(string[] args)
    {
        int n = 20;
        int[] numbers = new int[n];

        //initializing the array
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i * 5;
        }

        //printing the array
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

