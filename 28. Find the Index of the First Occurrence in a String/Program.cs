using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Find_the_Index_of_the_First_Occurrence_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (needle[0] == haystack[i])
                {
                    bool found = true;
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (needle[j] != haystack[i + j])
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                    {
                        return i;
                    }

                }
            }
            return -1;
        }
    }
}
