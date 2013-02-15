using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Lines
{
    static int maxLine = 1;
    static int countLines = 1;
    static Direction[] directions = new Direction[] { new Direction(0, 0,1), new Direction(0, 1, -1), 
                                                        new Direction(0, 1, 0), new Direction(0,1, 1), 
                                                        new Direction(1, -1, -1), new Direction(1, -1, 0), 
                                                        new Direction(1, -1, 1), new Direction(1, 0, -1),
                                                        new Direction(1, 0, 0),new Direction(1, 0, 1), 
                                                        new Direction(1, 1, -1),new Direction(1, 1, 0), 
                                                        new Direction(1, 1, 1),};

    static void Main(string[] args)
    {
        int width, height, depth;
        // Read the cuboid size
        string cuboidSize = Console.ReadLine();
        string[] metrix = cuboidSize.Split();
        width = int.Parse(metrix[0]);
        height = int.Parse(metrix[1]);
        depth = int.Parse(metrix[2]);
        char[, ,] cube = new char[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string input = Console.ReadLine();
            string[] colors = input.Split();
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = colors[d][w];
                }
            }
        }

        CalculateMaxLine(cube);
        if (maxLine == 1)
        {
            Console.WriteLine(-1);
            return;
        }
        Console.WriteLine(maxLine + " " + countLines);
    }

    static int LineLength(char[, ,] cube, int row, int column, int depth, Direction dir)
    {
        int result = 0;
        char color = cube[row,column,depth];
        while (row < cube.GetLength(0) && row >= 0 &&
              column < cube.GetLength(1) && column >= 0 &&
              depth < cube.GetLength(2) && depth >= 0 && cube[row, column, depth] == color)
        {
            result++;
            row += dir.XChange;
            column += dir.YChange;
            depth += dir.ZChange;
        }
        return result;
    }

    static void CalculateMaxLine(char[, ,] cube)
    {
        for (int row = 0; row < cube.GetLength(0); row++)
        {
            for (int column = 0; column < cube.GetLength(1); column++)
            {
                for (int depth = 0; depth < cube.GetLength(2); depth++)
                {
                    for (int dir = 0; dir < directions.Length; dir++)
                    {
                        int lineLength = LineLength(cube, row, column, depth, directions[dir]);
                        if (lineLength == maxLine)
                        {
                            countLines++;
                        }
                        if (lineLength > maxLine)
                        {
                            maxLine = lineLength;
                            countLines = 1;
                        }

                    }
                }
            }
        }
    }

    
}

class Direction
{
    public int XChange { get; private set; }

    public int YChange { get; private set; }

    public int ZChange { get; private set; }

    public Direction(int xChange, int yChange, int zChange)
    {
        this.XChange = xChange;
        this.YChange = yChange;
        this.ZChange = zChange;
    }
}