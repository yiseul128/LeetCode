using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125.Valid_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.IsPalindrome("A man, a plan, a canal: Panama")); //true
        }
    }
    public class Solution
    {
        public bool IsPalindrome(string s)
        {

            s = new String(s.Where(Char.IsLetterOrDigit).ToArray());
            s = s.ToLower();
            //Console.WriteLine(s);

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
