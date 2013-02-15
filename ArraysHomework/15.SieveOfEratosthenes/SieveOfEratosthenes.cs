using System;
using System.Collections.Generic;
class SieveOfEratosthenes
{
    static void Main(string[] args)
    {
        long n = 10000000l;
        long start = 3l;
        List<long> primeNumbers = new List<long>();
        primeNumbers.Add(2);
        while (start <= n)
        {
            bool prime = true;
            long primesCount = primeNumbers.Count;
            for (int i = 0; i < primesCount && primeNumbers[i] < Math.Sqrt(start); i++)
            {
                if (start % primeNumbers[i] == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                primeNumbers.Add(start);
            }
            start++;
        }
        /*foreach (int primeNumber in primeNumbers)
        {
            Console.Write(primeNumber + " ");
        }*/
        Console.WriteLine();

    }
}

