using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace _387.First_Unique_Character_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            OrderedDictionary chars = new OrderedDictionary();

            for (int i = 0; i < s.Length; i++)
            {
                string strC = s[i].ToString();
                if (chars.Contains(strC))
                {
                    // Console.WriteLine(chars[s[i]]);
                    chars[strC] = true;
                }
                else
                {
                    chars.Add(strC, false);
                }
            }

            ICollection keyCollection = chars.Keys;

            foreach (string c in keyCollection)
            {
                if ((bool)chars[c] == false)
                {
                    return s.IndexOf(c);
                }
            }
            return -1;
        }
    }
}
