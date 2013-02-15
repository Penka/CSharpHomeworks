using System;
class ComparingCharArrays
{
    static void Main(string[] args)
    {
        string firstArray = Console.ReadLine();
        string secondArray = Console.ReadLine();

        //no difference between A and a
        firstArray = firstArray.ToLower();
        secondArray = secondArray.ToLower();

        int longerArray = -1;
        /*-1 if the length of the first word is shorter than the length of the second array
         *0 if lengths are equal
         *1 if the first word is longer than the second one*/


        int minLength = firstArray.Length;
        if (minLength > secondArray.Length)
        {
            minLength = secondArray.Length;
            longerArray = 1;
        }
        else if (firstArray.Length == secondArray.Length)
        {
            longerArray = 0;
        }

        int index = 0;
        int difference = firstArray[index] - secondArray[index];
        index++;

        while (difference == 0 && index < minLength)
        {
            difference = firstArray[index] - secondArray[index];
            index++;
        }

        if (difference == 0) //all the chars so far are equal
        {
            if (longerArray == 0)
            {
                Console.WriteLine("Both words are equal");
            }
            else if (longerArray == -1)
            {
                Console.WriteLine("{0} is lexicographically before {1}", firstArray, secondArray);
            }
            else
            {
                Console.WriteLine("{0} is lexicographically before {1}", secondArray, firstArray);
            }
        }
        else if (difference < 0)
        {
            Console.WriteLine("{0} is lexicographically before {1}", firstArray, secondArray);
        }
        else
        {
            Console.WriteLine("{0} is lexicographically before {1}", secondArray, firstArray);
        }

    }
}

