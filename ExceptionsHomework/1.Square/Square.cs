using System;

class Square
{
    static double SquareRoot(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException("Negative number!");
        }
        return Math.Sqrt(n);
    }

    static void Main(string[] args)
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            double square = SquareRoot(n);
            Console.WriteLine(square);
        }
        catch(ArgumentOutOfRangeException)
        {
            Console.WriteLine("The inputed number is negative!");
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid format!");
        }
        finally
        {
            Console.WriteLine("Bye Bye");
        }
    }
}

