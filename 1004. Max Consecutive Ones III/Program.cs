public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        int max = 0;

        int start = 0;
        int end = 0;
        // find first end with k flipped
        while (0 != k && end < nums.Length)
        {
            // flip
            if (nums[end++] == 0)
            {
                k--;
            }
        }
        max = max > end - start ? max : end - start;

        // slide until end of nums
        while (end < nums.Length)
        {
            // flip
            if (nums[end++] == 0)
            {
                while (nums[start] != 0)
                {
                    start++;
                }
                start++;
            }
            max = max > end - start ? max : end - start;
        }

        return max;
    }
}