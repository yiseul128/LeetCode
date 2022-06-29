using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191.Number_of_1_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var i = 00000000000000000000000000001011U;
            Console.WriteLine(solution.HammingWeight(i)); //3
            //it passes in LeetCode but uint is directly turned into string (not to decimal val) in VS
        }
    }
    public class Solution
    {
        public int HammingWeight(uint n)
        {

            long intn = Convert.ToInt64(n.ToString());
            //Console.WriteLine(intn);
            int ans = 0;

            while (intn != 0)
            {
                if (intn % 2 == 1)
                {
                    ans++;
                }
                intn /= 2;
                //Console.WriteLine(intn + ", " + ans);
            }

            return ans;
        }
    }
}
