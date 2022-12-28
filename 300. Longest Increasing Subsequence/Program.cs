using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300.Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        int answer = 0;

        public int LengthOfLIS(int[] nums)
        {

            bool[] visited = new bool[nums.Length];
            int[] maxCounts = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                maxCounts[i] = -1;
            }

            RecurExplore(nums, -1, 0, visited, maxCounts);

            return answer;
        }

        public int RecurExplore(int[] nums, int prevIdx, int currCount, bool[] visited, int[] maxCounts)
        {
            answer = answer > currCount ? answer : currCount;

            // base
            if (prevIdx == nums.Length - 1)
            {
                return currCount;
            }

            int maxCount = currCount;
            for (int i = prevIdx + 1; i < nums.Length; i++)
            {
                if (prevIdx == -1 || nums[prevIdx] < nums[i])
                {
                    visited[i] = true;

                    int newCount = -1;
                    if (maxCounts[i] != -1)
                    {
                        newCount = currCount + maxCounts[i];
                        answer = answer > newCount ? answer : newCount;
                    }
                    else
                    {
                        newCount = RecurExplore(nums, i, currCount + 1, visited, maxCounts);
                    }

                    if (newCount > maxCount)
                    {
                        maxCount = newCount;
                    }

                    visited[i] = false;
                }
            }

            if (prevIdx != -1)
            {
                int newCount = maxCount - currCount + 1;
                maxCounts[prevIdx] = maxCounts[prevIdx] > newCount ? maxCounts[prevIdx] : newCount;
                // Console.WriteLine(prevIdx +": " + maxCounts[prevIdx]);
            }

            return maxCount;
        }
    }
}
