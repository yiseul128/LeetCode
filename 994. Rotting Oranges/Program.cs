using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _994.Rotting_Oranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        int[][] grid1;
        int[][] grid2;

        public int OrangesRotting(int[][] grid)
        {
            int freshCount = 0;

            grid2 = new int[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                grid2[i] = (int[])grid[i].Clone();
            }
            grid1 = grid;

            for (int r = 0; r < grid1.Length; r++)
            {
                for (int c = 0; c < grid1[0].Length; c++)
                {
                    // Console.WriteLine(r+", "+c +": "+grid[r][c]);
                    if (grid1[r][c] == 1)
                    {
                        freshCount++;
                    }
                }
            }

            if (freshCount == 0)
            {
                return 0;
            }

            return PassMinute(true, 1, freshCount);
        }

        public int PassMinute(bool useGrid1, int min, int lastFreshCount)
        {
            int freshCount = 0;

            if (useGrid1)
            {
                // rot 
                for (int r = 0; r < grid1.Length; r++)
                {
                    for (int c = 0; c < grid1[0].Length; c++)
                    {
                        // Console.WriteLine(r+", "+c +": "+grid[r][c]);
                        if (grid1[r][c] == 2)
                        {
                            grid2[r][c] = 2;
                            // left
                            if (c != 0 && grid1[r][c - 1] == 1)
                            {
                                grid2[r][c - 1] = 2;
                            }
                            // right
                            if (c != grid1[0].Length - 1 && grid1[r][c + 1] == 1)
                            {
                                grid2[r][c + 1] = 2;
                            }
                            // up
                            if (r != 0 && grid1[r - 1][c] == 1)
                            {
                                grid2[r - 1][c] = 2;
                            }
                            // downn
                            if (r != grid1.Length - 1 && grid1[r + 1][c] == 1)
                            {
                                grid2[r + 1][c] = 2;
                            }
                        }
                    }
                }

                // count how many fresh ones left 
                // Console.WriteLine("min: "+min);
                for (int r = 0; r < grid2.Length; r++)
                {
                    for (int c = 0; c < grid2[0].Length; c++)
                    {
                        // Console.WriteLine(r+", "+c +": "+grid2[r][c]);
                        if (grid2[r][c] == 1)
                        {
                            freshCount++;
                        }
                    }
                }
            }
            else
            {
                // rot 
                for (int r = 0; r < grid2.Length; r++)
                {
                    for (int c = 0; c < grid2[0].Length; c++)
                    {
                        // Console.WriteLine(r+", "+c +": "+grid[r][c]);
                        if (grid2[r][c] == 2)
                        {
                            grid1[r][c] = 2;
                            // left
                            if (c != 0 && grid2[r][c - 1] == 1)
                            {
                                grid1[r][c - 1] = 2;
                            }
                            // right
                            if (c != grid2[0].Length - 1 && grid2[r][c + 1] == 1)
                            {
                                grid1[r][c + 1] = 2;
                            }
                            // up
                            if (r != 0 && grid2[r - 1][c] == 1)
                            {
                                grid1[r - 1][c] = 2;
                            }
                            // downn
                            if (r != grid2.Length - 1 && grid2[r + 1][c] == 1)
                            {
                                grid1[r + 1][c] = 2;
                            }
                        }
                    }
                }

                // count how many fresh ones left 
                // Console.WriteLine("min: "+min);
                for (int r = 0; r < grid1.Length; r++)
                {
                    for (int c = 0; c < grid1[0].Length; c++)
                    {
                        // Console.WriteLine(r+", "+c +": "+grid1[r][c]);
                        if (grid1[r][c] == 1)
                        {
                            freshCount++;
                        }
                    }
                }
            }

            // all rotten
            if (freshCount == 0)
            {
                return min;
            }

            // impossible
            if (freshCount == lastFreshCount)
            {
                return -1;
            }

            // regular 
            return PassMinute(!useGrid1, min + 1, freshCount);
        }
    }
}
