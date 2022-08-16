using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215.Kth_Largest_Element_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {

            /* sol 1 : take longer */
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (counts.ContainsKey(nums[i]))
                {
                    counts[nums[i]]++;
                }
                else
                {
                    counts.Add(nums[i], 1);
                }
            }

            foreach (var c in counts.Reverse())
            {
                k -= c.Value;
                if (k <= 0)
                {
                    return c.Key;
                }
                //Console.WriteLine(c.Key + ", "+ c.Value);
            }

            return 0;

            /* sol 2 */
            /*int lim = 100000;
            int[] pos = new int[lim+1];
            int[] neg = new int[lim];

            for(int i = 0; i < nums.Length; i++){
                if(nums[i] < 0){
                    neg[nums[i]*-1]++;
                    continue;
                }
                pos[nums[i]]++;
            }

            int count = k;

            for(int i = lim; i >= 0; i--){
                if(pos[i]==0){
                    continue;
                }
                count-=pos[i];
                Console.WriteLine(i+", "+count);
                if(count<=0){
                    return i;
                }
            }

            for(int i = 1; i < lim; i++){
                if(neg[i]==0){
                    continue;
                }
                count-=neg[i];

                if(count<=0){
                    return -1*i;
                }
            }

            return 0;
            */
        }
    }
}
