using System;
class SentenceOfEqualElements
{
    static void Main(string[] args)
    {
        Console.Write("enter array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("enter element for index {0} ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int countMaxSequence = 1;
        int count = 1;
        int maxElement = numbers[0];
        int element = numbers[0];
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] == element)
            {
                count++;
            }
            else
            {
                if (countMaxSequence < count)
                {
                    maxElement = element;
                    countMaxSequence = count;
                }
                element = numbers[i];
                count = 1;
                
            }
        }



        //if all elements are equal
        if (countMaxSequence < count)
        {
            maxElement = element;
            countMaxSequence = count;
        }
        Console.WriteLine();
        Console.Write("{");
        for (int i = 0; i < countMaxSequence - 1; i++)
        {
            Console.Write(maxElement + ", ");
        }
        Console.WriteLine(maxElement + "}");

    }
}

