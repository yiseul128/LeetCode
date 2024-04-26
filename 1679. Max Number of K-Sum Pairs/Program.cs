public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        // sort
        Array.Sort(nums);

        int count = 0;

        // iterate
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            if (nums[left] + nums[right] == k)
            {
                // match
                count++;
                left++;
                right--;
            }
            else if (nums[left] + nums[right] < k)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return count;
    }
}