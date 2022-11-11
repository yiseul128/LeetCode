using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240.Search_a_2D_Matrix_II
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {

            bool bigger = true;
            int c = 0;

            for (int r = 0; r < matrix.Length; r++)
            {
                if (c == -1)
                {
                    // Console.WriteLine("min");
                    c++;
                }
                if (c == matrix[0].Length)
                {
                    // Console.WriteLine("max");
                    c--;
                }

                if (matrix[r][c] > target)
                {
                    bigger = false;
                }
                else if (matrix[r][c] < target)
                {
                    bigger = true;
                }

                while (c >= 0 && c < matrix[0].Length)
                {
                    // found target
                    if (matrix[r][c] == target)
                    {
                        return true;
                    }

                    if (matrix[r][c] > target)
                    {
                        if (bigger)
                        {
                            break;
                        }
                        else
                        {
                            c--;
                        }

                    }
                    else
                    {
                        if (bigger)
                        {
                            c++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return false;
        }
    }
}
