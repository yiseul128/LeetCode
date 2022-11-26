using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        IList<IList<int>> answer = new List<IList<int>>();
        public IList<IList<int>> Permute(int[] nums)
        {

            if (nums.Length == 1)
            {
                List<int> l = new List<int>();
                l.Add(nums[0]);
                answer.Add(l);
                return answer;
            }

            bool[] visited = new bool[nums.Length];
            BuildPerm(nums, visited, 0, new List<int>());

            return answer;
        }

        public void BuildPerm(int[] nums, bool[] visited, int idx, List<int> perm)
        {
            //base case
            if (perm.Count == nums.Length)
            {
                answer.Add(perm);
            }

            int newIdx = idx;

            for (int c = 0; c < nums.Length; c++)
            {
                if (!visited[newIdx])
                {
                    List<int> newPerm = new List<int>(perm);
                    newPerm.Add(nums[newIdx]);
                    visited[newIdx] = true;
                    BuildPerm(nums, visited, newIdx, newPerm);
                    visited[newIdx] = false;
                }
                newIdx = (newIdx + 1) % (nums.Length);
            }
        }
    }
}
