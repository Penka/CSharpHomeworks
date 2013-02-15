using System;
class SequenceOfEqualStrings
{
    /*static int MaxHorizontalLength(string[,] words, out int row, out int col, int rows, int cols)
    {
        int sequenceCount = 0;
        int maxSequenceCount = 0;
        row = -1;
        col = -1;

        for (int i = 0; i < rows; i++)
        {
            sequenceCount = 1;
            for (int j = 0; j < cols - 1; j++)
            {
                if(words[i, j].Equals(words[i, j + 1]))
                {
                    sequenceCount++;
                }
                else
                {
                    sequenceCount = 1;
                }
                if(sequenceCount > maxSequenceCount)
                {
                    maxSequenceCount = sequenceCount;
                    row = i;
                    col = j + 1;
                }
            }
        }
        return maxSequenceCount;
    }

    static int MaxVerticalLength(string[,] words, out int row, out int col, int rows, int cols)
    {
        int sequenceCount = 0;
        int maxSequenceCount = 0;
        row = -1;
        col = -1;

        for (int i = 0; i < cols; i++)
        {
            sequenceCount = 1;
            for (int j = 0; j < rows - 1; j++)
            {
                if (words[j, i].Equals(words[j + 1, i]))
                {
                    sequenceCount++;
                }
                else
                {
                    sequenceCount = 1;
                }
                if (sequenceCount > maxSequenceCount)
                {
                    maxSequenceCount = sequenceCount;
                    row = j + 1;
                    col = i;
                }
            }
        }
        return maxSequenceCount;
    }

    static int MaxDiagonalLength(string[,] words, out int row, out int col)
    {
        int sequenceCount = 0;
        int maxSequenceCount = 0;
        row = -1;
        col = -1;

        for (int i = 0, j = 0; i < words.GetLength(0) && j<words.GetLength(1); i++,j++)
        {
            
        }
        return maxSequenceCount;
    }
    */
    static int MaxHorizontalLength(string[,] words, int row, int col)
    {
        int count = 1;
        for (int i = col + 1; i < words.GetLength(1); i++)
        {
            if (words[row, i].CompareTo(words[row, col]) != 0)
            {
                return count;
            }
            count++;
        }
        return count;
    }

    static int MaxVerticalLength(string[,] words, int row, int col)
    {
        int count = 1;
        for (int i = row + 1; i < words.GetLength(0); i++)
        {
            if (words[i, col].CompareTo(words[row, col]) != 0)
            {
                return count;
            }
            count++;
        }
        return count;
    }
    static int MaxDiagonalLength(string[,] words, int row, int col)
    {
        int count = 1;
        for (int i = row + 1, j = col + 1; i < words.GetLength(0) && j < words.GetLength(1); i++, j++)
        {
            if (words[row, col].CompareTo(words[i, j]) != 0)
            {
                return count;
            }
            count++;
        }
        return count;
    }


    static void Main(string[] args)
    {
        /*Console.Write("rows = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("columns = ");
        int columns = int.Parse(Console.ReadLine());
        string[,] words = new string[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("element at row {0} and column {1} = ", i, j);
                words[i, j] = Console.ReadLine();
            }
        }*/
        int rows = 3;
        int cols = 4;
        string[,] myWords = new string[,] {{"ha", "fifi", "ho", "hi"},
        {"fo", "ha", "hi", "xx"},
        {"xxx", "ho", "ha", "xx"}};

        int maxSequence = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int countVertical = MaxVerticalLength(myWords, i, j);
                int countHorizontal = MaxHorizontalLength(myWords, i, j);
                int countDiagonal = MaxDiagonalLength(myWords, i, j);
                if (maxSequence < countVertical)
                {
                    maxSequence = countVertical;
                }
                if (maxSequence < countHorizontal)
                {
                    maxSequence = countHorizontal;
                }
                if (maxSequence < countDiagonal)
                {
                    maxSequence = countDiagonal;
                }
            }
        }
        Console.WriteLine(maxSequence);
    }
}

