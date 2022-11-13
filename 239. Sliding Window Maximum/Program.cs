using System;
using System.Collections.Generic;

namespace _239._Sliding_Window_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] input = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int[] output = s.MaxSlidingWindow(input, 3);

            for(int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
    public class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] max = new int[nums.Length - k + 1];

            PriorityQueue<int, int> window = new PriorityQueue<int, int>();

            for (int i = 0; i < k; i++)
            {
                window.Enqueue(i, -1 * nums[i]);
            }

            window.TryPeek(out int e, out int p);
            max[0] = p * -1;

            for (int i = k; i < nums.Length; i++)
            {
                // add
                window.Enqueue(i, -1 * nums[i]);

                // set max
                while (true)
                {
                    window.TryPeek(out int idx, out int num);

                    if (idx > i - k)
                    {
                        // Console.WriteLine("max=> i: "+ i +", idx: " + idx + ", num: " + num);
                        max[i - k + 1] = -1 * num;
                        break;
                    }
                    {
                        // Console.WriteLine("deq=> i: "+ i +", idx: " + idx + ", num: " + num);
                        window.Dequeue();
                    }
                }
            }

            return max;
        }
    }
}
