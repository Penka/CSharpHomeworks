using System;
class ComparingArrays
{
    static void Main(string[] args)
    {
        Console.Write("First array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int[] comparedArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0} for the first array ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Second array length: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0} for the second array ", i);
            comparedArray[i] = int.Parse(Console.ReadLine());
        }

       
        if (n != m) //the arrays are with different length so there is no need to check element by element
        {
            Console.WriteLine("The arrays are not equal");
            return;
        }

        bool equals = true;

        for (int i = 0; i < n; i++)
        {
            if (array[i] != comparedArray[i])
            {
                equals = false;
                break;
            }
        }
        if (equals)
        {
            Console.WriteLine("The arrays are equal");
        }
        else
        {
            Console.WriteLine("The arrays are not equal");
        }
    }
}
