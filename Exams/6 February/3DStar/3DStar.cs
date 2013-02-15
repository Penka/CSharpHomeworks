using System;
using System.Collections.Generic;

using System.Linq;

class Program
{

    static bool IsStar(char[, ,] cube, int width, int height, int depth)
    {
        char color = cube[width, height, depth];
        if (cube[width + 1, height, depth] == color && cube[width - 1, height, depth] == color
            && cube[width, height + 1, depth] == color && cube[width, height - 1, depth] == color
            && cube[width, height, depth + 1] == color && cube[width, height, depth - 1] == color)
        {
            return true;
        }
        return false;
    }

    /*static bool IsOutOfRange(char[,,] cube, int width, int height, int depth)
    {
        if (!(width > 0 || width < cube.GetLength(0) - 1))
        {
            return true;
        }
        if (!(height > 0 && height < cube.GetLength(1)))
        {
            return true;
        }
        if (!(depth > 0 && depth < cube.GetLength(2)))
        {
            return true;
        }
        return false;
    }
    */
    static void Main(string[] args)
    {

        //w h d
        string size = Console.ReadLine();
        string[] c = size.Split(' ');

        int width = int.Parse(c[0]);
        int height = int.Parse(c[1]);
        int depth = int.Parse(c[2]);

        char[, ,] cube = new char[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string line = Console.ReadLine();
            string[] letters = line.Split();
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = letters[d][w];
                }
            }
        }

        Dictionary<char, int> result = new Dictionary<char, int>();
        int count = 0;
        for (int i = 1; i < width - 1; i++)
        {
            for (int j = 1; j < height - 1; j++)
            {
                for (int k = 1; k < depth - 1; k++)
                {
                    char color = cube[i, j, k];
                    if (cube[i + 1, j, k] == color && cube[i - 1, j, k] == color
                        && cube[i, j + 1, k] == color && cube[i, j - 1, k] == color
                        && cube[i, j, k + 1] == color && cube[i, j, k - 1] == color)
                    {
                        count++;
                        if (!result.ContainsKey(color))
                        {
                            result.Add(color, 1);
                        }
                        else
                        {
                            result[color]++;
                        }
                    }
                }
            }
        }

        Console.WriteLine(count);
        List<char> colors = new List<char>();
        foreach (KeyValuePair<char, int> pair in result)
        {
            colors.Add(pair.Key);
        }
        colors.Sort();

        for (int i = 0; i < colors.Count; i++)
        {
            Console.WriteLine("{0} {1}", colors[i], result[colors[i]]);
        }


    }
}

