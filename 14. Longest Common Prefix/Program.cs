using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string[] strs = {"flower", "flow", "flight"};
            Console.WriteLine(s.LongestCommonPrefix(strs)); //fl
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {

            if (strs.Length == 1)
            {
                return strs[0];
            }

            int minLength = strs[0].Length;

            //get min length of strs elements
            for (int i = 0; i < strs.Length - 1; i++)
            {
                if (strs[i].Length > strs[i + 1].Length)
                {
                    minLength = minLength > strs[i + 1].Length ? strs[i + 1].Length : minLength;
                }
                else
                {
                    minLength = minLength > strs[i].Length ? strs[i].Length : minLength;
                }

                //Console.WriteLine(minLength);
            }

            string prefix = "";
            for (int i = 0; i < minLength; i++)
            {

                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != strs[j - 1][i])
                    {
                        return prefix;
                    }
                }

                prefix += strs[0][i].ToString();
                //Console.WriteLine(prefix);
            }

            return prefix;
        }
    }
}
