using System;

class TicTacToe
{
    static int wins = 0;
    static int loses = 0;
    static int even = 0;

    static bool HorizontalWin(char[,] board, char ch)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            bool victory = true;
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] != ch)
                {
                    victory = false;
                    break;
                }
            }
            if (victory)
            {
                return true;
            }
        }
        return false;
    }

    static bool VerticalWin(char[,] board, char ch)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            bool victory = true;
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[j, i] != ch)
                {
                    victory = false;
                    break;
                }
            }
            if (victory)
            {
                return true;
            }
        }
        return false;
    }

    static bool RightDiagonalWin(char[,] board, char ch)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, i] != ch)
            {
                return false;
            }
        }
        return true;
    }

    static bool LeftDiagonalWin(char[,] board, char ch)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, board.GetLength(0) - 1 - i] != ch)
            {
                return false;
            }
        }
        return true;
    }

    static bool Win(char[,] board, char ch)
    {
        return HorizontalWin(board, ch) || VerticalWin(board, ch) || RightDiagonalWin(board, ch) || LeftDiagonalWin(board, ch);
    }

    static bool EndOfGame(char[,] board)
    {
        int xCounter = 0;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == 'X')
                {
                    xCounter++;
                }
            }
        }
        return xCounter == ((board.GetLength(0) * board.GetLength(1)) / 2 + 1);
    }

    static int EndResult(char[,] board)
    {

        if (Win(board, 'X'))
        {
            return 1;
        }
        if (Win(board, 'O'))
        {
            return -1;
        }
        if (EndOfGame(board))
        {
            return 0;
        }
        return -2; // the game is not over yet
    }

    static void Play(char[,] board, bool xOnTurn)
    {
        // Print(board);
        int endRes = EndResult(board);
        if (endRes == 0)
        {
            
            even++;
            return;
        }
        else if (endRes == 1)
        {
            wins++;
            return;
        }
        else if (endRes == -1)
        {
            loses++;
            return;
        }
        else
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == '-')
                    {
                        if (xOnTurn)
                        {
                            board[i, j] = 'X';
                            Play(board, false);
                        }
                        else
                        {
                            board[i, j] = 'O';
                            Play(board, true);
                        }
                        board[i, j] = '-';
                    }
                }
            }
        }
    }

    //static void Print(char[,] board)
    //{
    //    Console.WriteLine("printing... ");
    //    for (int i = 0; i < board.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < board.GetLength(1); j++)
    //        {
    //            Console.Write(board[i, j] + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    static bool XIsOnTurn(char[,] board)
    {
        int xCount = 0;
        int oCount = 0;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == 'X')
                {
                    xCount++;
                }
                else if (board[i, j] == 'O')
                {
                    oCount++;
                }
            }
        }
        return (xCount - oCount) <= 0;
    }

    static void Main(string[] args)
    {
        int n = 3;
        char[,] board = new char[n, n];
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            for (int j = 0; j < str.Length; j++)
            {
                board[i, j] = str[j];
            }
        }

        bool xOnTurn = XIsOnTurn(board);

        Play(board, xOnTurn);
        Console.WriteLine(wins);
        Console.WriteLine(even);
        Console.WriteLine(loses);
    }
}

