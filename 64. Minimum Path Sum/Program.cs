using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64.Minimum_Path_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[][] dists;
        public int MinPathSum(int[][] grid)
        {

            // distance board
            dists = new int[grid.Length][];
            int MAX_INT = 40000000;

            for (int i = 0; i < grid.Length; i++)
            {
                dists[i] = new int[grid[0].Length];
                for (int j = 0; j < grid[0].Length; j++)
                {
                    dists[i][j] = MAX_INT;
                }
            }
            dists[0][0] = grid[0][0];

            // find paths 
            FindPaths(grid, 0, 0);

            return dists[grid.Length - 1][grid[0].Length - 1];
        }

        public void FindPaths(int[][] grid, int r, int c)
        {
            // base case
            if (r == grid.Length - 1 && c == grid[0].Length - 1)
            {
                return;
            }

            // update dist and recur
            if (r < grid.Length - 1)
            {
                // down
                int newDist = dists[r][c] + grid[r + 1][c];
                if (dists[r + 1][c] > newDist)
                {
                    dists[r + 1][c] = newDist;
                    FindPaths(grid, r + 1, c);
                }
            }
            if (c < grid[0].Length - 1)
            {
                // right
                int newDist = dists[r][c] + grid[r][c + 1];
                if (dists[r][c + 1] > newDist)
                {
                    dists[r][c + 1] = newDist;
                    FindPaths(grid, r, c + 1);
                }
            }

        }
    }
}
