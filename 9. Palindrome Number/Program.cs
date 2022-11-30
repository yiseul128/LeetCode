using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            string strX = x.ToString();

            int len = strX.Length;
            if (len == 1)
            {
                return true;
            }

            for (int i = 0; i < len / 2; i++)
            {
                if (strX[i] != strX[len - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
