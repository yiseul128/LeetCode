using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.Valid_Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {

            for (int r = 0; r < 9; r++)
            {
                HashSet<char> v = new HashSet<char>();
                HashSet<char> h = new HashSet<char>();
                for (int c = 0; c < 9; c++)
                {
                    // horizontal 
                    if (board[r][c] != '.')
                    {
                        if (h.Contains(board[r][c]))
                        {
                            return false;
                        }
                        h.Add(board[r][c]);
                    }

                    //vertical
                    if (board[c][r] != '.')
                    {
                        if (v.Contains(board[c][r]))
                        {
                            return false;
                        }
                        v.Add(board[c][r]);
                    }
                }
            }

            // sub box
            int[] rs = { 0, 3, 6, 0, 3, 6, 0, 3, 6 };
            int[] cs = { 0, 0, 0, 3, 3, 3, 6, 6, 6 };
            for (int i = 0; i < 9; i++)
            {
                int curr = rs[i];
                int curc = cs[i];
                HashSet<char> b = new HashSet<char>();

                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (board[curr + r][curc + c] != '.')
                        {
                            if (b.Contains(board[curr + r][curc + c]))
                            {
                                return false;
                            }
                            b.Add(board[curr + r][curc + c]);
                        }
                    }
                }
            }

            return true;
        }
    }
}
