using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51.N_Queens
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            List<IList<string>> answer = new List<IList<string>>();
            bool[][] board = new bool[n][];
            for (int i = 0; i < n; i++)
            {
                board[i] = new bool[n];
            }

            RecurSolve(board, 0, answer);

            return answer;
        }

        public void RecurSolve(bool[][] board, int row, IList<IList<string>> answer)
        {
            if (row == board.Length)
            {
                // add to answer
                List<string> placement = new List<string>();

                for (int r = 0; r < board.Length; r++)
                {
                    string currRow = "";
                    for (int c = 0; c < board.Length; c++)
                    {
                        if (board[r][c])
                        {
                            currRow += "Q";
                        }
                        else
                        {
                            currRow += ".";
                        }
                    }
                    placement.Add(currRow);
                }

                answer.Add(placement);
                return;
            }

            for (int col = 0; col < board.Length; col++)
            {
                if (ValidatePlacement(board, row, col))
                {
                    // put Q
                    board[row][col] = true;

                    // recurr
                    RecurSolve(board, row + 1, answer);

                    // remove Q
                    board[row][col] = false;
                }
            }
        }

        public bool ValidatePlacement(bool[][] board, int row, int col)
        {

            for (int i = 0; i < board.Length; i++)
            {
                // vertical
                if (board[i][col])
                {
                    return false;
                }

                // diagonal 
                // down right 
                if (row + i < board.Length && col + i < board.Length && board[row + i][col + i])
                {
                    return false;
                }
                // down left
                if (row + i < board.Length && col - i >= 0 && board[row + i][col - i])
                {
                    return false;
                }
                // up right
                if (row - i >= 0 && col + i < board.Length && board[row - i][col + i])
                {
                    return false;
                }
                // up left
                if (row - i >= 0 && col - i >= 0 && board[row - i][col - i])
                {
                    return false;
                }
            }

            return true;
        }
        

        /* old sln */
        //IList<IList<string>> answer;
        //HashSet<string> found = new HashSet<string>();

        //public IList<IList<string>> SolveNQueens(int n)
        //{
        //    answer = new List<IList<string>>();
        //    int[] queens = new int[n];
        //    bool[] visited = new bool[n];

        //    ResetBoard(queens);
        //    RecurSolve(n, 0, 0, queens);

        //    return answer;
        //}

        //public void RecurSolve(int n, int r, int c, int[] queens)
        //{
        //    if (r == n)
        //    {
        //        // add to answer
        //        string q = "";
        //        for (int j = 0; j < n; j++)
        //        {
        //            q += queens[j].ToString();
        //        }
        //        if (found.Contains(q))
        //        {
        //            return;
        //        }

        //        List<string> leftToRight = new List<string>();

        //        for (int row = 0; row < n; row++)
        //        {
        //            for (int col = 0; col < n; col++)
        //            {
        //                if (queens[col] == row)
        //                {
        //                    leftToRight.Add(new string('.', col) + "Q" + new string('.', n - col - 1));
        //                }
        //            }
        //        }
        //        answer.Add(leftToRight);
        //        found.Add(q);
        //        // Console.WriteLine(q);
        //        return;
        //    }

        //    for (int i = 0; i < n; i++)
        //    {
        //        c = (c + 1) % n;
        //        // Console.WriteLine("r: " + r + ", c: "+c  + ", i: "+i );
        //        if (queens[c] == -1 && Check(r, c, n, queens))
        //        {
        //            queens[c] = r;
        //            RecurSolve(n, r + 1, c + 1, queens);
        //            queens[c] = -1;
        //        }
        //    }
        //}

        //public bool Check(int r, int c, int n, int[] queens)
        //{
        //    for (int i = 1; i < queens.Length; i++)
        //    {
        //        // diagonal
        //        if (r + i < n && c + i < n)
        //        {
        //            if (queens[c + i] == r + i)
        //            {
        //                return false;
        //            }
        //        }
        //        if (r - i > -1 && c + i < n)
        //        {
        //            if (queens[c + i] == r - i)
        //            {
        //                return false;
        //            }
        //        }
        //        if (r + i < n && c - i > -1)
        //        {
        //            if (queens[c - i] == r + i)
        //            {
        //                return false;
        //            }
        //        }
        //        if (r - i > -1 && c - i > -1)
        //        {
        //            if (queens[c - i] == r - i)
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}

        //public void ResetBoard(int[] queens)
        //{
        //    for (int i = 0; i < queens.Length; i++)
        //    {
        //        queens[i] = -1;
        //    }
        //}
    }
}
