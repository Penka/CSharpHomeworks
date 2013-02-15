using System;
using System.Collections.Generic;
namespace _6.MatrixManipulation
{
    /*Write a class Matrix, to holds a matrix of integers. 
     * Overload the operators for adding, subtracting and multiplying of matrices,
     * indexer for accessing the matrix content and ToString().
*/
    class Matrix
    {
        private int rows;
        private int cols;
        private int[,] matrix;
        public int Rows
        {
            set { this.rows = value; }
            get { return this.rows; }
        }
        public int Cols
        {
            set { this.cols = value; }
            get { return this.cols; }
        }

        public void SetElementAt(int value, int row, int col)
        {
            this.matrix[row, col] = value;
        }

        public int GetElementAt(int row, int col)
        {
            return matrix[row, col];
        }
        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrix = new int[rows, cols];
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            int rows = a.Rows;
            int cols = a.Cols;
            if (rows != b.Rows || cols != b.Cols)
            {
                return null;//the matrix can't be added
            }
            Matrix result = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    int sum = a.GetElementAt(i, j) + b.GetElementAt(i, j);
                    result.SetElementAt(sum, i, j);
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            int rows = a.Rows;
            int cols = a.Cols;
            if (rows != b.Rows || cols != b.Cols)
            {
                return null;//the matrix can't be subtacted
            }
            Matrix result = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int sub = a.GetElementAt(i, j) - b.GetElementAt(i, j);
                    result.SetElementAt(sub, i, j);
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            int rows = a.Rows;
            int cols = a.Cols;
            if (cols != b.Rows)
            {
                return null;//the matrix can't be multiplyed
            }
            Matrix result = new Matrix(rows, b.Cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < b.Cols; j++)
                {
                    int sum = 0;
                    
                    for (int k = 0; k < cols; k++)
                    {
                        sum = sum + a.GetElementAt(i, k) * b.GetElementAt(k, j);
                    }
                    
                    result.SetElementAt(sum, i, j);
                }
            }
            return result;
        }


        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    output = output + matrix[i,j] + " ";
                }
                output = output + "\n";
            }
            return output;
        }

        

    }
}
