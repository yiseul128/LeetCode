using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _227.Basic_Calculator_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int Calculate(string s)
        {
            List<int> nums = new List<int>();
            List<char> ops = new List<char>();

            // build nums and ops
            int l = 0;
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] == ' ')
                {
                    if (l != 0)
                    {
                        nums.Add(Convert.ToInt32(s.Substring(i - l, l)));
                        // Console.WriteLine(Convert.ToInt32(s.Substring(i-l, l)));
                        l = 0;
                    }

                    i++;

                    continue;
                }

                // operations
                if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/')
                {
                    if (l != 0)
                    {
                        nums.Add(Convert.ToInt32(s.Substring(i - l, l)));
                        // Console.WriteLine(Convert.ToInt32(s.Substring(i-l, l)));
                        l = 0;
                    }
                    // Console.WriteLine(s[i]);
                    ops.Add(s[i]);
                }
                // num length ++
                else
                {
                    l++;
                }

                i++;
            }

            if (l != 0)
            {
                nums.Add(Convert.ToInt32(s.Substring(i - l, l)));
                // Console.WriteLine(Convert.ToInt32(s.Substring(i-l, l)));
                l = 0;
            }

            // calculate * and /  
            int idx = 0;
            while (idx < ops.Count)
            {
                Console.WriteLine(ops.ElementAt(idx));
                if (ops.ElementAt(idx) == '*')
                {
                    int n1 = nums.ElementAt(idx);
                    int n2 = nums.ElementAt(idx + 1);
                    nums.RemoveAt(idx);
                    nums.RemoveAt(idx);
                    //Console.WriteLine("n1: " + n1 +", n2: " + n2);
                    nums.Insert(idx, n1 * n2);
                    ops.RemoveAt(idx);
                }
                else if (ops.ElementAt(idx) == '/')
                {
                    int n1 = nums.ElementAt(idx);
                    int n2 = nums.ElementAt(idx + 1);
                    nums.RemoveAt(idx);
                    nums.RemoveAt(idx);
                    //Console.WriteLine("n1: " + n1 +", n2: " + n2);
                    nums.Insert(idx, n1 / n2);
                    ops.RemoveAt(idx);
                }
                else
                {
                    idx++;
                }
            }

            idx = 0;
            while (ops.Count > 0)
            {
                if (ops.ElementAt(idx) == '+')
                {
                    nums.Insert(idx, nums.ElementAt(idx) + nums.ElementAt(idx + 1));
                    nums.RemoveAt(idx + 1);
                    nums.RemoveAt(idx + 1);
                    ops.RemoveAt(idx);
                }
                else
                {
                    nums.Insert(idx, nums.ElementAt(idx) - nums.ElementAt(idx + 1));
                    nums.RemoveAt(idx + 1);
                    nums.RemoveAt(idx + 1);
                    ops.RemoveAt(idx);
                }
            }

            return nums.ElementAt(0);
        }
    }
}
