using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> answer = new List<IList<int>>();
            Array.Sort(nums);
            Dictionary<long, HashSet<int>> numsDict = new Dictionary<long, HashSet<int>>();
            long[] numsLong = nums.Select(i => (long)i).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numsDict.ContainsKey(numsLong[i]))
                {
                    numsDict.Add(numsLong[i], new HashSet<int>());
                }
                numsDict[numsLong[i]].Add(i);
            }

            int prevS = -1;
            for (int s = 0; s < numsLong.Length - 2; s++)
            {
                if (numsLong[s] > 0)
                {
                    break;
                }

                if (prevS != -1 && numsLong[prevS] == numsLong[s])
                {
                    continue;
                }
                prevS = s;

                int prevL = -1;
                for (int l = numsLong.Length - 1; l > s + 1; l--)
                {
                    if (numsLong[l] < 0)
                    {
                        break;
                    }

                    if (prevL != -1 && numsLong[prevL] == numsLong[l])
                    {
                        continue;
                    }
                    prevL = l;

                    long target = numsLong[s] + numsLong[l];
                    target *= -1;
                    if (target < numsLong[s] || target > numsLong[l])
                    {
                        continue;
                    }

                    if (numsDict.ContainsKey(target))
                    {

                        int c = numsDict[target].Count;
                        if (numsDict[target].Contains(s))
                        {
                            c--;
                        }
                        if (numsDict[target].Contains(l))
                        {
                            c--;
                        }

                        if (c > 0)
                        {
                            List<int> triplet = new List<int> { (int)numsLong[s], (int)target, (int)numsLong[l] };
                            answer.Add(triplet);
                        }

                    }
                }
            }


            // N3 solution fail
            /*
            int prevS = -1;
            for(int s = 0; s < numsLong.Length-2; s++){     
                if(numsLong[s] > 0){
                    break;
                }

                if(prevS != -1 && numsLong[prevS] == numsLong[s]){
                    continue;
                }
                prevS = s;

                int prevL = -1;
                for(int l = numsLong.Length -1; l > s+1; l--){
                    if(numsLong[l]<0){
                        break;
                    }

                    if(prevL != -1 && numsLong[prevL] == numsLong[l]){
                        continue;
                    }  
                    prevL = l;

                    long target = -1 * (numsLong[s] + numsLong[l]);

                    if(target > 0){
                        int prevM = -1;
                        for(int m = s+1; m < l; m++){
                            if(prevM != -1 && numsLong[prevM] == numsLong[m]){
                                continue;
                            }
                            prevM = m;

                            if(target < numsLong[m]){
                                break;
                            }
                            if(target == numsLong[m]){
                                List<int> triplet = new List<int>{(int)numsLong[s], (int)numsLong[m], (int)numsLong[l]}; 
                                answer.Add(triplet);
                                break;
                            }
                        }   
                    }
                    else{
                        int prevM = -1;
                        for(int m = l-1; m > s; m--){
                            if(prevM != -1 && numsLong[prevM] == numsLong[m]){
                                continue;
                            }
                            prevM = m;

                            if(target > numsLong[m]){
                                break;
                            }
                            if(target == numsLong[m]){
                                List<int> triplet = new List<int>{(int)numsLong[s], (int)numsLong[m], (int)numsLong[l]}; 
                                answer.Add(triplet);
                                break;
                            }
                        }   
                    }    

                }
            }
            */

            return answer;

        }
    }
}
