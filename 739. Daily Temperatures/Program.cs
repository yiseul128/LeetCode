using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _739.Daily_Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] answer = new int[temperatures.Length];

            for (int i = 0; i < temperatures.Length; i++)
            {
                for (int j = i + 1; j < temperatures.Length; j++)
                {
                    if (temperatures[i] < temperatures[j])
                    {
                        answer[i] = j - i;
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
