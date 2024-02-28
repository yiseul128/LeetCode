using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.Unique_Paths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int answer = solution.UniquePaths(3, 2);
        }
    }

    public class Solution
    {
        /* recursive with memo */
        public int UniquePaths(int m, int n)
        {
            int[,] memo = new int[m + 1, n + 1];
            return RecurUniquePaths(m, n, 1, 1, memo);
        }

        public int RecurUniquePaths(int m, int n, int r, int c, int[,] memo)
        {
            // finish!
            if (m == r && n == c)
            {
                return 1;
            }

            if (memo[r, c] != 0)
            {
                return memo[r, c];
            }

            int count = 0;
            // recur if next cell available
            if (m > r)
            {
                count += RecurUniquePaths(m, n, r + 1, c, memo);
            }

            if (n > c)
            {
                count += RecurUniquePaths(m, n, r, c + 1, memo);
            }

            memo[r, c] = count;

            return count;
        }
        //public int UniquePaths(int m, int n)
        //{
        //    int smaller = m - 1 < n - 1 ? m - 1 : n - 1;
        //    int bigger = m - 1 > n - 1 ? m - 1 : n - 1;

        //    long denominator = 1;
        //    for (int i = 2; i <= smaller; i++)
        //    {
        //        denominator *= Convert.ToInt64(i);
        //    }

        //    long numerator = 1;
        //    bool divided = false;
        //    for (int i = bigger + 1; i <= smaller + bigger; i++)
        //    {
        //        numerator *= Convert.ToInt64(i);

        //        if (!divided && numerator % denominator == 0)
        //        {
        //            numerator /= denominator;
        //            divided = true;
        //        }
        //    }

        //    return Convert.ToInt32(numerator);

        //}
    }
}
