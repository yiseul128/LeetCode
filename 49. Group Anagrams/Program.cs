using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.Group_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {

            IList<IList<string>> ans = new List<IList<string>>();

            string[] sorted = new string[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                sorted[i] = new string(strs[i].OrderBy(c => c).ToArray());
                //Console.WriteLine(sorted[i]);
            }

            bool[] taken = new bool[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                if (taken[i] == true)
                {
                    continue;
                }

                IList<string> forThis = new List<string>();
                forThis.Add(strs[i]);
                taken[i] = true;
                for (int j = i + 1; j < strs.Length; j++)
                {
                    if (sorted[j] == sorted[i])
                    {
                        forThis.Add(strs[j]);
                        taken[j] = true;
                    }
                }

                ans.Add(forThis);
            }

            return ans;
        }
    }
}
