using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _384.Shuffle_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        int[] original;
        Random random;

        public Solution(int[] nums)
        {
            original = nums;
            random = new Random();
        }

        public int[] Reset()
        {
            return original;
        }

        public int[] Shuffle()
        {
            int[] shuffleArr = new int[original.Length];
            List<int> list = original.OfType<int>().ToList();

            int i = 0;
            while (list.Count != 0)
            {
                int randIndex = random.Next(list.Count);
                shuffleArr[i] = list[randIndex];
                list.Remove(shuffleArr[i]);
                i++;
            }

            return shuffleArr;
        }
    }

    /**
     * Your Solution object will be instantiated and called as such:
     * Solution obj = new Solution(nums);
     * int[] param_1 = obj.Reset();
     * int[] param_2 = obj.Shuffle();
     */
}
