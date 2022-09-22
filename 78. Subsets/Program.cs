using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78.Subsets
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        int[] givenN;
        IList<IList<int>> answer;
        public IList<IList<int>> Subsets(int[] nums)
        {
            givenN = nums;
            answer = new List<IList<int>>();
            answer.Add(new List<int>());

            for (int c = 1; c <= givenN.Length; c++)
            {
                List<int> l = new List<int>();
                FindSubset(0, c, l);
            }

            return answer;

        }
        public void FindSubset(int i, int c, List<int> sub)
        {
            if (i > givenN.Length - 1)
            {
                return;
            }

            FindSubset(i + 1, c, new List<int>(sub));
            sub.Add(givenN[i]);
            if (c == 1)
            {
                answer.Add(sub);
            }
            FindSubset(i + 1, c - 1, new List<int>(sub));

        }
    }
}
