using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74.Search_a_2D_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int row = -1;
            int col = 0;

            for (int r = 0; r < matrix.Length; r++)
            {
                if (matrix[r][0] == target)
                {
                    return true;
                }
                else if (matrix[r][0] < target)
                {
                    row = r;
                }
            }

            if (row == -1)
            {
                return false;
            }

            bool[][] visited = new bool[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                visited[i] = new bool[matrix[0].Length];
            }

            while (row < matrix.Length)
            {
                visited[row][col] = true;

                if (matrix[row][col] == target)
                {
                    return true;
                }
                else if (matrix[row][col] < target)
                {
                    if (col < matrix[0].Length - 1 && !visited[row][col + 1])
                    {
                        col++;
                    }
                    else
                    {
                        row++;
                    }
                }
                else
                {
                    if (col > 0 && !visited[row][col - 1])
                    {
                        col--;
                    }
                    else
                    {
                        row++;
                    }
                }
            }

            return false;
        }
    }
}
