using System;
class BinarySearch
{
    static int BinarySearchMethod(int[] array, int k, int start, int end)
    {
        if(start > end)
        {
            return -1;
        }
        else
        {
            int middle = (start + end)/2;

            if(array[middle] > k)
            {
               return BinarySearchMethod(array, k, start, middle - 1);
            }
            else if(array[middle] < k)
            {
                return BinarySearchMethod(array, k, middle + 1, end);
            }
            else
            {
                return middle;
            }
        }
    }
   
    static void Main(string[] args)
    {
        int n = 10;
        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int k = int.Parse(Console.ReadLine());
        int index = BinarySearchMethod(sortedArray, k, 0, n - 1);
        //index = Array.BinarySearch(sortedArray, k);
        Console.WriteLine(index);
    }
}

