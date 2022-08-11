using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200.Number_of_Islands
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        bool[,] visited;
        int count = 0;
        char[][] givenBoard;
        int rn, cn;

        public int NumIslands(char[][] grid)
        {
            visited = new bool[grid.Length, grid[0].Length];
            givenBoard = grid;
            rn = grid.Length;
            cn = grid[0].Length;

            for (int i = 0; i < rn; i++)
            {
                for (int j = 0; j < cn; j++)
                {
                    if (!visited[i, j])
                    {
                        if (grid[i][j] == '1')
                        {
                            count++;
                            FindIsland(i, j);
                        }
                    }
                }
            }

            return count;
        }

        public void FindIsland(int r, int c)
        {
            if (r >= 0 && r < rn && c >= 0 && c < cn)
            {
                if (visited[r, c])
                {
                    return;
                }
                if (givenBoard[r][c] == '1')
                {
                    visited[r, c] = true;
                    FindIsland(r - 1, c); //d
                    FindIsland(r + 1, c); //u
                    FindIsland(r, c - 1); //l
                    FindIsland(r, c + 1); //r
                    //Console.WriteLine("(" + r + ", " + c + ")");
                }
            }
        }
    }
}
