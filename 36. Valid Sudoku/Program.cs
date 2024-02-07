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

            // vertical & horizontal
            for (int r = 0; r < 9; r++)
            {
                bool[] v = new bool[10];
                bool[] h = new bool[10];

                for (int c = 0; c < 9; c++)
                {
                    if (board[r][c] != '.')
                    {
                        int currNum = Int32.Parse(board[r][c].ToString());
                        if (h[currNum])
                        {
                            return false;
                        }
                        h[currNum] = true;
                    }

                    if (board[c][r] != '.')
                    {
                        int currNum = Int32.Parse(board[c][r].ToString());
                        if (v[currNum])
                        {
                            return false;
                        }
                        v[currNum] = true;
                    }
                }
            }

            // boxes
            int[] rs = { 0, 3, 6, 0, 3, 6, 0, 3, 6 };
            int[] cs = { 0, 0, 0, 3, 3, 3, 6, 6, 6 };
            for (int i = 0; i < 9; i++)
            {
                int curr = rs[i];
                int curc = cs[i];
                bool[] b = new bool[10];

                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (board[curr + r][curc + c] != '.')
                        {
                            int currNum = Int32.Parse(board[curr + r][curc + c].ToString());
                            if (b[currNum])
                            {
                                return false;
                            }
                            b[currNum] = true;
                        }
                    }
                }
            }

            return true;
        }
    }
}
