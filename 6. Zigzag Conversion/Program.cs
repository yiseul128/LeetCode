using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Zigzag_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            Queue<char>[] rows = new Queue<char>[numRows];

            for (int i = 0; i < numRows; i++)
            {
                rows[i] = new Queue<char>();
            }

            int r = 0;
            bool positive = true;
            for (int i = 0; i < s.Length; i++)
            {

                rows[r].Enqueue(s[i]);

                if (r == 0)
                {
                    positive = true;
                }
                else if (r == numRows - 1)
                {
                    positive = false;
                }

                if (positive)
                {
                    r++;
                }
                else
                {
                    r--;
                }
            }

            string answer = "";
            for (int i = 0; i < numRows; i++)
            {
                while (rows[i].Count != 0)
                {
                    answer += rows[i].Dequeue().ToString();
                }
            }

            return answer;
        }
    }
}
