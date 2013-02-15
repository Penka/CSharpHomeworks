using System;
using System.Collections.Generic;
class IncreasingSubArray
{
    /*
     * * Write a program that reads an array of integers and 
     * removes from it a minimal number of elements in such way that the remaining 
     * array is sorted in increasing order. Print the remaining sorted array. Example:
	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
*/

    static bool isIncreasing(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int length = numbers.Count;
        List<int> increasing = new List<int>();
        int currenLength = 0;
        int maxLength = 0;
        
    }
}

