using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] arr = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            s.SpiralOrder(arr);
        }

    }
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> ans = new List<int>();

            bool[,] visited = new bool[matrix.Length, matrix[0].Length];

            int r = 0;
            int c = 0;

            //deal with single col, multi rows
            if (matrix[0].Length == 1)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    ans.Add(matrix[i][0]);
                }
                return ans;
            }

            //right
            for (int i = c; i < matrix[0].Length; i++)
            {
                if (!visited[r, i])
                {
                    ans.Add(matrix[r][i]);
                    visited[r, i] = true;
                    c = i;
                }
                else
                {
                    break;
                }
            }
            while (true)
            {

                //down
                if (r == matrix.Length - 1 || (r != matrix.Length - 1 && visited[r + 1, c]))
                {
                    return ans;
                }
                r++;
                for (int i = r; i < matrix.Length; i++)
                {
                    if (!visited[i, c])
                    {
                        ans.Add(matrix[i][c]);
                        visited[i, c] = true;
                        r = i;
                    }
                    else
                    {
                        break;
                    }
                }

                //left
                if (visited[r, c - 1])
                {
                    return ans;
                }
                c--;
                for (int i = c; i >= 0; i--)
                {
                    if (!visited[r, i])
                    {
                        ans.Add(matrix[r][i]);
                        visited[r, i] = true;
                        c = i;
                    }
                    else
                    {
                        break;
                    }
                }

                //up
                if (visited[r - 1, c])
                {
                    return ans;
                }
                r--;
                for (int i = r; i >= 0; i--)
                {
                    if (!visited[i, c])
                    {
                        ans.Add(matrix[i][c]);
                        visited[i, c] = true;
                        r = i;
                    }
                    else
                    {
                        break;
                    }
                }

                //right
                if (c == matrix[0].Length - 1 || (c != matrix[0].Length - 1 && visited[r, c + 1]))
                {
                    return ans;
                }
                c++;
                for (int i = c; i < matrix[0].Length; i++)
                {
                    if (!visited[r, i])
                    {
                        ans.Add(matrix[r][i]);
                        visited[r, i] = true;
                        c = i;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
}
