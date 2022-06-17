using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _134.Gas_Station
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gas = { 1, 2, 3, 4, 5 };
            int[] cost = { 3, 4, 5, 1, 2 };

            Solution s = new Solution();
            Console.WriteLine(s.CanCompleteCircuit(gas, cost));
        }
    }

    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            for (int i = 0; i < gas.Length; i++)//start point
            { 
                if (gas[i] < 1)
                {
                    continue;
                }
                int curStation = i;
                int curGas = gas[curStation];
                while (true)
                {
                    curGas -= cost[curStation];
                    if (curGas < 0)
                    {
                        break; //go to next start point
                    }

                    //update station and gas
                    if (curStation == gas.Length - 1)
                    {
                        curStation = 0;
                    }
                    else
                    {
                        curStation++;
                    }

                    if (curStation == i) //back to start point
                    { 
                        return i;
                    }

                    curGas += gas[curStation];
                };
            }

            return -1;
        }
    }
}
