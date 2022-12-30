using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.Combination_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        List<IList<int>> answer;

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            answer = new List<IList<int>>();
            Array.Sort(candidates);

            FindCombinations(candidates, target, 0, 0, new List<int>());

            return answer;
        }

        public void FindCombinations(int[] candidates, int target, int idx, int sum, List<int> combination)
        {
            if (target == sum)
            {
                answer.Add(combination);
                return;
            }

            if (idx > candidates.Length - 1)
            {
                return;
            }

            for (int i = idx; i < candidates.Length; i++)
            {
                if (target < sum + candidates[i])
                {
                    return;
                }
                List<int> newCombination = new List<int>(combination);
                newCombination.Add(candidates[i]);
                FindCombinations(candidates, target, i, sum + candidates[i], newCombination);
            }
        }
    }
}
