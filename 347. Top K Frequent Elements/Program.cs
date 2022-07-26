using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _347.Top_K_Frequent_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>(); //n, count

            for (int i = 0; i < nums.Length; i++)
            {
                if (!frequency.ContainsKey(nums[i]))
                {
                    frequency.Add(nums[i], 1);
                }
                else
                {
                    frequency[nums[i]] = frequency[nums[i]] + 1;
                }
            }

            frequency = frequency.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int[] keys = frequency.Keys.ToArray();
            int[] answer = new int[k];
            for (int i = 0; i < k; i++)
            {
                answer[i] = keys[i];
            }

            return answer;

        }
    }
}
