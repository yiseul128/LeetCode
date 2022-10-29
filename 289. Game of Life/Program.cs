using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _289.Game_of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public void GameOfLife(int[][] board)
        {
            int[][] nextState = new int[board.Length][];
            for (int i = 0; i < board.Length; i++)
            {
                nextState[i] = new int[board[0].Length];
            }

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {
                    int count = 0;
                    // left top
                    if (r != 0 && c != 0 && board[r - 1][c - 1] == 1)
                    {
                        count++;
                    }
                    // middle top
                    if (r != 0 && board[r - 1][c] == 1)
                    {
                        count++;
                    }
                    // right top
                    if (r != 0 && c != board[0].Length - 1 && board[r - 1][c + 1] == 1)
                    {
                        count++;
                    }
                    // left middle
                    if (c != 0 && board[r][c - 1] == 1)
                    {
                        count++;
                    }
                    // right middle
                    if (c != board[0].Length - 1 && board[r][c + 1] == 1)
                    {
                        count++;
                    }
                    // left bottom
                    if (r != board.Length - 1 && c != 0 && board[r + 1][c - 1] == 1)
                    {
                        count++;
                    }
                    // middle bottom
                    if (r != board.Length - 1 && board[r + 1][c] == 1)
                    {
                        count++;
                    }
                    // right bottom
                    if (r != board.Length - 1 && c != board[0].Length - 1 && board[r + 1][c + 1] == 1)
                    {
                        count++;
                    }

                    // dead
                    if (board[r][c] == 0)
                    {
                        if (count == 3)
                        {
                            nextState[r][c] = 1;
                        }
                    }
                    // live
                    else
                    {
                        if (count == 2 || count == 3)
                        {
                            nextState[r][c] = 1;
                        }
                    }

                }
            }

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {
                    board[r][c] = nextState[r][c];
                }
            }

            // board = nextState;
        }
    }
}
