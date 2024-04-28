public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int rightSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            rightSum += nums[i];
        }

        int leftSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];

            if (rightSum == leftSum)
            {
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}