using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _378.Kth_Smallest_Element_in_a_Sorted_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            int n = matrix.Length;
            int min = matrix[0][0];
            int max = matrix[n - 1][n - 1];

            while (min < max)
            {
                int mid = min + (max - min) / 2;
                // Console.WriteLine("min: " + min + ", max: "+ max + ", mid: "+ mid);

                int count = 0;
                int r = 0;
                int c = 0;
                while (r < n)
                {
                    if (c == n || matrix[r][c] > mid)
                    {
                        r++;
                        c = 0;
                    }
                    else
                    {
                        count++;
                        c++;
                    }
                }

                // Console.WriteLine("count: " + count);
                // if(count == k){
                //     return mid;
                // }
                if (count < k)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid;
                }
            }
            // min will be correct val because binary search stops when max - min = 1
            return min;
        }
    }
}
