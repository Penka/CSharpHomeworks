using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Combinations
{
    static void CalculateCombinations(List<int> numbers, int k, List<int> currentState, int index)
    {
        if (k == 0)
        {
            foreach (var item in currentState)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            return;
        }

        for (int i = index; i <= numbers.Count - k; i++)
        {
            currentState.Add(numbers[i]);

            CalculateCombinations(numbers, k - 1, currentState, i + 1);
            currentState.RemoveAt(currentState.Count - 1);
        }
    }


    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>(n);
        for (int i = 0; i < n; i++)
        {
            numbers.Add(i + 1);
        }
        CalculateCombinations(numbers, k, new List<int>(), 0);
    }
}
