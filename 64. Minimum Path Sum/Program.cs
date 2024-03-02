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
        public int MinPathSum(int[][] grid)
        {
            int[,] memo = new int[grid.Length, grid[0].Length];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    memo[i, j] = Int32.MaxValue;
                }
            }
            RecurMinPath(grid, 0, 0, 0, memo);

            return memo[grid.Length - 1, grid[0].Length - 1] + grid[grid.Length - 1][grid[0].Length - 1];
        }

        public void RecurMinPath(int[][] grid, int r, int c, int sum, int[,] memo)
        {
            if (memo[r, c] > sum)
            {
                memo[r, c] = sum;
            }
            else
            {
                return;
            }

            // finish!
            if (grid.Length - 1 == r && grid[0].Length - 1 == c)
            {
                return;
            }

            sum += grid[r][c];
            // recur if next cell available
            if (grid.Length - 1 > r)
            {
                RecurMinPath(grid, r + 1, c, sum, memo);
            }

            if (grid[0].Length - 1 > c)
            {
                RecurMinPath(grid, r, c + 1, sum, memo);
            }
        }
    }
}
