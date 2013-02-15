using System;
using System.Collections.Generic;

namespace _6.MatrixManipulation
{
    class MatrixManipulation
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int cols = 3;
            Matrix a = new Matrix(rows, cols);
            int counter = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    a.SetElementAt(counter, i, j);
                    counter++;
                }
            }
            Console.WriteLine(a.ToString());

            Matrix b = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    b.SetElementAt(counter, i, j);
                    counter++;
                }
            }
            Console.WriteLine(b.ToString());

            Matrix sum = new Matrix(rows, cols);
            sum = a + b;
            Console.WriteLine(sum.ToString());

            Matrix sub = new Matrix(rows, cols);
            sub = a - b;
            Console.WriteLine(sub.ToString());

            Matrix mult = new Matrix(rows, cols);
            mult = a * b;
            Console.WriteLine(mult.ToString());
        }
    }
}
