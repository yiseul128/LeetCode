using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.Count_and_Say
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string CountAndSay(int n)
        {
            return CountAndSayRecur(n, "1");
        }

        public string CountAndSayRecur(int n, string s)
        {
            if (n == 1)
            {
                return s;
            }

            if (s.Length == 1)
            {
                return CountAndSayRecur(n - 1, "1" + s);
            }

            string s2 = "";
            char prev = s[0];
            int count = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (prev == s[i])
                {
                    count++;
                }
                else
                {
                    s2 += count.ToString() + prev.ToString();
                    count = 1;
                    prev = s[i];
                }
            }
            s2 += count.ToString() + prev.ToString();
            //Console.WriteLine(s2 + ", " + n);
            return CountAndSayRecur(n - 1, s2);
        }


    }
}
