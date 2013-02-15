using System;
using System.Collections.Generic;

class Tubes
{

    static long Cut(long[] tubes, long lowLimit, long upLimit, long cuts)
    {
        long middle = (upLimit + lowLimit) / 2;
        long count = CountPieces(tubes, middle);
        if (upLimit == lowLimit)
        {
            
            if (count >= cuts)
            {
                return lowLimit;
            }
            else
            {
                return -1;
            }
        }
        if (upLimit - lowLimit == 1)
        {
            long upCount = CountPieces(tubes, upLimit);
            if (upCount >= cuts)
            {
                return upLimit;
            }
            else
            {
                if (count >= cuts)
                {
                    return lowLimit;
                }
                else
                {
                    return -1;
                }
            }
        }

        if (count >= cuts)
        {
            return Cut(tubes, middle, upLimit, cuts);
        }
        else
        {
            return Cut(tubes, lowLimit, middle - 1, cuts);
        }
    }
  
    private static long CountPieces(long[] tubes, long middle)
    {
        long count = 0;

        for (int i = 0; i < tubes.Length; i++)
        {
            count += tubes[i] / middle;
        }
        return count;
    }

    static void Main(string[] args)
    {
        int tubesCount = int.Parse(Console.ReadLine());
        long cuts = long.Parse(Console.ReadLine());

        long[] tubes = new long[tubesCount];
        for (int i = 0; i < tubesCount; i++)
        {
            tubes[i] = long.Parse(Console.ReadLine());
        }

        long minTube = tubes[0];
        long maxTube = tubes[0];

        for (int i = 0; i < tubesCount; i++)
        {
            if (minTube > tubes[i])
            {
                minTube = tubes[i];
            }
            if (maxTube < tubes[i])
            {
                maxTube = tubes[i];
            }
        }
        long result = Cut(tubes, 1, maxTube, cuts);
        Console.WriteLine(result);

    }
}

