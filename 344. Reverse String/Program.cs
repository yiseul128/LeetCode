using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _344.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int len = s.Length - 1;
            int half = len % 2 == 0 ? len / 2 : len / 2 + 1;

            for (int i = 0; i < half; i++)
            {
                char temp = s[i];
                s[i] = s[len - i];
                s[len - i] = temp;
            }
        }
    }
}
