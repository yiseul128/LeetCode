using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Container_With_Most_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 }; //49

            Console.WriteLine(solution.MaxArea(height));
        }
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int max = 0;

            for (int i = 0; i < height.Length - 1; i++)
            {
                if (max > height[i] * height.Length)
                { //pass if possible max is smaller
                    continue;
                }

                for (int j = i; j < height.Length; j++)
                {
                    int newMax = (height[i] < height[j] ? height[i] : height[j]) * (j - i);

                    max = max > newMax ? max : newMax;
                }
            }

            return max;
        }
    }
}
