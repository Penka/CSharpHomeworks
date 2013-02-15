using System;
using System.Collections.Generic;
class Matrix
{
    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, 3}", matrix[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[j, i] = counter;
                counter++;
            }
        }
        PrintMatrix(matrix);
        counter = 1;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = counter;
                    counter++;
                }
            }
            else
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    matrix[j, i] = counter;
                    counter++;
                }
            }
        }
        PrintMatrix(matrix);

        counter = 1;
        for (int i = 0; i < 2 * n; i++)
        {
            int cols;
            if (i < n)
            {
                cols = 0;
            }
            else
            {
                cols = i - n + 1;
            }
            for (int j = i - cols; j >= cols; j--)
            {
                matrix[n - 1 - j, i - j] = counter;
                counter++;
            }

        }
        PrintMatrix(matrix);

        int left = 0;
        int right = n - 1;
        int top = 0;
        int bottom = n - 1;
        counter = 1;
        while (left < right && top < bottom)
        {


            //down
            for (int i = top; i <= bottom; i++)
            {
                matrix[i, left] = counter;
                counter++;
            }
            left++;

            //right
            for (int i = left; i <= right; i++)
            {
                matrix[bottom, i] = counter;
                counter++;
            }
            bottom--;

            //up
            for (int i = bottom; i >= top; i--)
            {
                matrix[i, right] = counter;
                counter++;
            }
            right--;

            //left
            for (int i = right; i >= left; i--)
            {
                matrix[top, i] = counter;
                counter++;
            }
            top++;
        }
        PrintMatrix(matrix);
    }
}

