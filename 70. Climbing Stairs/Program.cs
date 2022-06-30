using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70.Climbing_Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.ClimbStairs(9)); //55
        }
    }
    public class Solution
    {
        int[] memo;
        public int ClimbStairs(int n)
        {
            memo = new int[46];
            memo[1] = 1;
            memo[2] = 2;

            if (n < 3)
            {
                return memo[n];
            }

            recurClimb(n, 3);

            return memo[n];

        }

        public void recurClimb(int n, int current)
        {
            memo[current] = memo[current - 1] + memo[current - 2];

            if (current != n)
            {
                recurClimb(n, current + 1);
            }

        }
    }
}
