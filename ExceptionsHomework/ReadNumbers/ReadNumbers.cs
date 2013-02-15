using System;
class ReadNumbers
{
    static int ReadNumber(int start, int end)
    {
        string input = Console.ReadLine();
        int number;
        if (!int.TryParse(input, out number))
        {
            throw new FormatException();
        }
        if (!(number >= start && number <= end))
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }
    static void Main(string[] args)
    {
        try
        {
            int n = 10;
            int[] numbers = new int[n];
            numbers[0] = ReadNumber(10, 100);
            for (int i = 1; i < n; i++)
            {
                numbers[i] = ReadNumber(numbers[i - 1], 100);
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The inputed number is not in the correct range!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format!");
        }

    }
}

