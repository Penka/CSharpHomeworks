using System;
using System.Collections.Generic;
class RectangularMatrix
{


    static void Main(string[] args)
    {
        Console.Write("rows = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("columns = ");
        int columns = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("element at row {0} and column {1} = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int n = 3;
        int maximalSum = 0;
        int sum = 0;
        int maxRow = 0;
        int maxCol = 0;
        for (int i = 0; i < rows - n + 1; i++)
        {
            for (int j = 0; j < columns - n + 1; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int p = 0; p < n; p++)
                    {
                        sum += matrix[i + k, j + p];
                    }
                }
                if (maximalSum < sum)
                {
                    maximalSum = sum;
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[maxRow + i, maxCol + j] + " ");
            }
            Console.WriteLine();
        }
    }
}

