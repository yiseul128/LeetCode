using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _118.Pascal_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> answer = new List<IList<int>>();
            List<int> first = new List<int>();
            first.Add(1);
            answer.Add(first);

            if (numRows == 1)
            {
                return answer;
            }

            List<int> second = new List<int>();
            second.Add(1);
            second.Add(1);
            answer.Add(second);

            List<int> prevRow = second;
            for (int i = 2; i < numRows; i++)
            {
                List<int> newRow = new List<int>();
                newRow.Add(1);

                int prev = 1;
                bool firstEl = false;
                foreach (int j in prevRow)
                {
                    if (!firstEl)
                    {
                        firstEl = true;
                        continue;
                    }

                    newRow.Add(prev + j);
                    prev = j;
                }

                newRow.Add(1);

                answer.Add(newRow);
                prevRow = newRow;
            }

            return answer;
        }
    }
}
