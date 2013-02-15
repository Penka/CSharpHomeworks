using System;
using System.IO;
class MaxSum
{
    static void Main(string[] args)
    {
        string inputFilePath = "../../matrix.txt";
        StreamReader file = new StreamReader(inputFilePath);
        using (file)
        {
            int row = 0;
            string line = file.ReadLine();
            int n = int.Parse(line);
            int[,] matrix = new int[n, n];
            while ((line = file.ReadLine()) != null)
            {
                string[] numbers = line.Split(' ');
                for (int i = 0; i < n; i++)
                {
                    matrix[row, i] = int.Parse(numbers[i]);
                }
                row++;
            }
            int maxSum = int.MinValue;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}

