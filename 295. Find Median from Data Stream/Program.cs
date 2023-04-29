using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _295.Find_Median_from_Data_Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class MedianFinder
    {
        List<int> nums;

        public MedianFinder()
        {
            nums = new List<int>();
        }

        public void AddNum(int num)
        {
            int count = nums.BinarySearch(num);

            count = count < 0 ? ~count : count;

            nums.Insert(count, num);
        }

        public double FindMedian()
        {
            int middle = nums.Count / 2;

            if (nums.Count % 2 == 0)
            {
                return ((double)nums.ElementAt(middle) + nums.ElementAt(middle - 1)) / 2;
            }
            else
            {
                return (double)nums.ElementAt(middle);
            }
        }
    }

    /**
     * Your MedianFinder object will be instantiated and called as such:
     * MedianFinder obj = new MedianFinder();
     * obj.AddNum(num);
     * double param_2 = obj.FindMedian();
     */
}
