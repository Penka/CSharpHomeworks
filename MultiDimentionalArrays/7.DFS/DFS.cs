using System;
using System.Collections.Generic;
class DepthFirstSearch
{
    static int[,] matrix = { { 1, 3, 2, 2, 2, 4 },
                        { 3, 3, 3, 2, 4, 4 }, 
                        { 4, 3, 1, 2, 3, 3 }, 
                        { 4, 3, 1, 3, 3, 1 }, 
                        { 4, 3, 3, 3, 1, 1 } };
    static bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

    static bool IsInRange(int row, int column)
    {
        if(row >= 0 && row < matrix.GetLength(0) && column >= 0 && column < matrix.GetLength(1))
        {
            return true;
        }
         return false;
    }

    static int DFS(int n, int row, int column)
    {
        if(!IsInRange(row, column))
        {
            return 0;
        }
        if(visited[row, column] || matrix[row, column]!= n)
        {
            return 0;
        }
        visited[row, column] = true;
        int sum =  DFS(n,row, column + 1) + DFS(n,row, column - 1) +
               DFS(n, row + 1, column) + DFS(n,row - 1, column) + 1;
        return sum;
    }

    static void Main(string[] args)
    {
        /*Console.Write("rows = ");
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
        }*/
        int max = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int current = DFS(matrix[row, col], row, col);

                if (current > max)
                {
                    max = current;
                }
            }
        }
        Console.WriteLine(max);

    }
}

