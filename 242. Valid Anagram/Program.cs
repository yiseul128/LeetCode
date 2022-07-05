using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242.Valid_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.IsAnagram("anagram", "nagaram")); //true
        }
    }
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            /* simpler answer (not that faster among other leet code answers though)
             
            string sortedS = new string (s.OrderBy(c => c).ToArray());
            string sortedT = new string (t.OrderBy(c => c).ToArray());
                
            return (sortedS == sortedT);
             
             */

            if (s.Length != t.Length)
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < t.Length; j++)
                {
                    if (s[i] == t[j])
                    {

                        t = t.Substring(0, j) + t.Substring(j + 1);
                        //Console.WriteLine(t);
                        break;
                    }

                    if (j == t.Length - 1)
                    {
                        return false;
                    }
                }
            }

            if (t.Length > 0)
            {
                return false;
            }

            return true;
        }
    }
}
