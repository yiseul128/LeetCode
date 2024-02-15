using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.Merge_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            /* solution using less memory with sort and merge */
            //// bubble sort
            //int n = intervals.Length;
            //for (int i = 0; i < n; i++)
            //{
            //    bool swapped = false;
            //    for (int j = 0; j < n - i - 1; j++)
            //    {
            //        //swap
            //        if (intervals[j][0] > intervals[j + 1][0])
            //        {
            //            int[] temp = intervals[j + 1];
            //            intervals[j + 1] = intervals[j];
            //            intervals[j] = temp;
            //            swapped = true;
            //        }
            //    }

            //    if (!swapped)
            //    {
            //        break;
            //    }
            //}

            //// merge
            //List<int[]> mergedList = new List<int[]>();
            //for (int i = 0; i < n - 1; i++)
            //{
            //    //Console.WriteLine($"{intervals[i][0]} {intervals[i][1]}");

            //    if (intervals[i][1] >= intervals[i + 1][0] && intervals[i][1] <= intervals[i + 1][1])
            //    {
            //        int[] merged = new int[] { intervals[i][0], intervals[i + 1][1] };
            //        intervals[i + 1] = merged;
            //    }
            //    else if (intervals[i][1] >= intervals[i + 1][1])
            //    {
            //        intervals[i + 1] = intervals[i];
            //    }
            //    else
            //    {
            //        mergedList.Add(intervals[i]);
            //    }
            //}
            //mergedList.Add(intervals[n - 1]);

            //return mergedList.ToArray();

            SortedDictionary<int, List<string>> range = new SortedDictionary<int, List<string>>();

            for (int i = 0; i < intervals.Length; i++)
            {
                int currStart = intervals[i][0];
                int currEnd = intervals[i][1];

                if (range.ContainsKey(currStart))
                {
                    range[currStart].Add("start");
                }
                else
                {
                    //Console.WriteLine("s: " + currStart);
                    List<string> newList = new List<string>();
                    newList.Add("start");
                    range.Add(currStart, newList);
                }

                if (range.ContainsKey(currEnd))
                {
                    range[currEnd].Add("end");
                }
                else
                {
                    //Console.WriteLine("e: " + currEnd);
                    List<string> newList = new List<string>();
                    newList.Add("end");
                    range.Add(currEnd, newList);
                }
            }

            int openCount = 0;
            int start = 10001;
            int end = 10001;
            int[] newInterval = new int[2];
            newInterval[0] = start;
            newInterval[1] = end;
            List<int[]> intervalList = new List<int[]>();
            foreach (var el in range)
            {

                foreach (string s in el.Value)
                {
                    Console.WriteLine(el.Key + ", " + s + ", " + openCount);

                    if (s == "start")
                    {
                        if (openCount == 0)
                        {
                            start = el.Key;
                        }
                        openCount++;
                    }
                    else
                    {
                        end = el.Key;
                        if (openCount == 1)
                        {
                            if (start == newInterval[1])
                            {
                                //Console.WriteLine("new end: "+end +", 0: " +newInterval[0]+", 1: " +newInterval[1]);
                                newInterval[1] = end;
                                openCount = 0;
                            }
                            else
                            {
                                newInterval = new int[2];
                                newInterval[0] = start;
                                newInterval[1] = end;
                                intervalList.Add(newInterval);
                                openCount = 0;
                            }
                        }
                        else
                        {
                            openCount--;
                        }
                    }
                }
            }

            int[][] answer = new int[intervalList.Count][];

            int c = 0;
            foreach (int[] interval in intervalList)
            {
                answer[c] = interval;
                c++;
            }

            return answer;
        }
    }
}
