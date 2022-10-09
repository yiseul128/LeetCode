using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149.Max_Points_on_a_Line
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int MaxPoints(int[][] points)
        {
            if (points.Length < 3)
            {
                return points.Length;
            }

            int max = 2;

            for (int i = 0; i < points.Length; i++)
            {
                int curMax = 2;
                Dictionary<string, int> slopes = new Dictionary<string, int>();
                for (int j = 0; j < points.Length; j++)
                {
                    if (i == j)
                    {
                        //skip
                        continue;
                    }

                    string s = "";
                    if (points[i][0] == points[j][0])
                    {
                        s = "x" + points[i][0].ToString();
                    }
                    else if (points[i][1] == points[j][1])
                    {
                        s = "y" + points[i][1].ToString();
                    }
                    else
                    {
                        s = (((double)points[i][0] - points[j][0]) / ((double)points[i][1] - points[j][1])).ToString();
                    }
                    // Console.WriteLine(s);
                    if (slopes.ContainsKey(s))
                    {
                        // Console.WriteLine("found: " + s);
                        slopes[s]++;
                        curMax = curMax > slopes[s] ? curMax : slopes[s];
                    }
                    else
                    {
                        // Console.WriteLine("add: " + s);
                        slopes.Add(s, 2);
                    }
                }
                max = max > curMax ? max : curMax;
            }

            return max;
        }
    }
}
