using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383.Note
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            string note = "aa", magazine = "aab";
            Console.WriteLine(s.CanConstruct(note, magazine)); //true

            magazine = "ab";
            Console.WriteLine(s.CanConstruct(note, magazine)); //false
        }
    }

    public class Solution
    {
        public bool CanConstruct(string note, string magazine)
        {
            bool found = false;
            for (int i = 0; i < note.Length; i++)
            {
                found = false;
                for (int j = 0; j < magazine.Length; j++)
                {
                    if (note[i] == magazine[j])
                    {
                        found = true;
                        magazine = magazine.Remove(j, 1);
                        //Console.WriteLine(magazine);
                        break;
                    }
                }
                if (found == false)
                {
                    return false;
                }
            }
            if (found)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
