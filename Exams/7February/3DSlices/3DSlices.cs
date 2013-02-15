using System;
using System.Collections.Generic;

class Slices
{
    static int[] SumsWidth(int[, ,] cube)
    {
        //depth width, height
        int[] sums = new int[cube.GetLength(1)];
        for (int i = 0; i < cube.GetLength(0); i++)
        {
            {
                for (int k = 0; k < cube.GetLength(2); k++)
                {
                    sums[0] += cube[i, 0, k];
                }
            }

        }
        for (int j = 1; j < cube.GetLength(1); j++)
        {
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int k = 0; k < cube.GetLength(2); k++)
                {
                    sums[j] += cube[i, j, k];
                }
            }
            sums[j] += sums[j - 1];

        }

        return sums;
    }

    static int[] SumsDepth(int[, ,] cube)
    {
        //depth width, height
        int[] sums = new int[cube.GetLength(0)];
        for (int i = 0; i < cube.GetLength(1); i++)
        {
            {
                for (int k = 0; k < cube.GetLength(2); k++)
                {
                    sums[0] += cube[0, i, k];
                }
            }

        }
        for (int j = 1; j < cube.GetLength(0); j++)
        {
            for (int i = 0; i < cube.GetLength(1); i++)
            {
                for (int k = 0; k < cube.GetLength(2); k++)
                {
                    sums[j] += cube[j, i, k];
                }
            }
            sums[j] += sums[j - 1];

        }

        return sums;
    }

    static int[] SumsHeight(int[, ,] cube)
    {//depth width, height
        int[] sums = new int[cube.GetLength(2)];
        for (int i = 0; i < cube.GetLength(0); i++)
        {
            {
                for (int k = 0; k < cube.GetLength(1); k++)
                {
                    sums[0] += cube[i, k, 0];
                }
            }

        }
        for (int j = 1; j < cube.GetLength(2); j++)
        {
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int k = 0; k < cube.GetLength(1); k++)
                {
                    sums[j] += cube[i, k, j];
                }
            }
            sums[j] += sums[j - 1];

        }

        return sums;
    }

    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static int CountEqualSums(int[] array, int totalSum)
    {
        int count = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (2 * array[i] == totalSum)
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] metrics = input.Split(' ');
        int width = int.Parse(metrics[0]);
        int height = int.Parse(metrics[1]);
        int depth = int.Parse(metrics[2]);
        string[] m = new string[height];
        for (int i = 0; i < height; i++)
        {
            m[i] = Console.ReadLine();
        }
        string[] separator = new string[] { " | " };

        int totalSum = 0;
        int[, ,] cube = new int[depth, width, height];
        for (int i = 0; i < height; i++)
        {
            string[] a = m[i].Split(separator, StringSplitOptions.None);
            if (a.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int j = 0; j < depth; j++)
            {
                for (int k = 0; k < width; k++)
                {
                    string[] res = a[j].Split(' ');
                    cube[j, k, i] = int.Parse(res[k]);
                    totalSum += cube[j, k, i];
                }
            }
        }
        int[] widths = SumsWidth(cube);
        int[] depths = SumsDepth(cube);
        int[] heights = SumsHeight(cube);
        //Print(widths);
        //Print(heights);
        //Print(depths);
        int count = 0;
        count += CountEqualSums(widths, totalSum);
        count += CountEqualSums(heights, totalSum);
        count += CountEqualSums(depths, totalSum);

        Console.WriteLine(count);
    }
}

