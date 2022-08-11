using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130.Surrounded_Regions
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        bool[,] notFlip;
        int rn = 0;
        int cn = 0;
        char[][] givenBoard;

        public void Solve(char[][] board)
        {
            notFlip = new bool[board.Length, board[0].Length];
            rn = board.Length;
            cn = board[0].Length;
            givenBoard = board;

            //top
            for (int i = 0; i < cn; i++)
            {
                findNotToFlip(0, i);
            }

            //bottom
            for (int i = 0; i < cn; i++)
            {
                findNotToFlip(rn - 1, i);
            }

            //left
            for (int i = 0; i < rn; i++)
            {
                findNotToFlip(i, 0);
            }

            //right
            for (int i = 0; i < rn; i++)
            {
                findNotToFlip(i, cn - 1);
            }

            for (int r = 1; r < rn - 1; r++)
            {
                for (int c = 1; c < cn - 1; c++)
                {
                    if (!notFlip[r, c])
                    {
                        board[r][c] = 'X';
                    }
                }
            }

        }

        public void findNotToFlip(int r, int c)
        {
            if (r >= 0 && r < rn && c >= 0 && c < cn)
            {
                if (notFlip[r, c])
                {
                    return;
                }
                if (givenBoard[r][c] == 'O')
                {
                    notFlip[r, c] = true;
                    findNotToFlip(r - 1, c); //d
                    findNotToFlip(r + 1, c); //u
                    findNotToFlip(r, c - 1); //l
                    findNotToFlip(r, c + 1); //r
                                             //Console.WriteLine("(" + r + ", " + c + ")");
                }
            }
        }
    }
}
