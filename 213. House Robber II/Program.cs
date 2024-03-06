public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length < 4)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                max = max > nums[i] ? max : nums[i];
            }
            return max;
        }

        int[] memo = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length + 1; i++)
        {
            memo[i] = Int32.MinValue;
        }
        Rob(nums, memo, 0, 0, nums.Length - 1);

        for (int i = 0; i < nums.Length; i++)
        {
            memo[i] = Int32.MinValue;
        }
        Rob(nums, memo, 1, 0, nums.Length);
        Rob(nums, memo, 2, 0, nums.Length);
        return memo[nums.Length];
    }

    public void Rob(int[] nums, int[] memo, int idx, int sum, int endIdx)
    {
        // end
        if (idx >= endIdx)
        {
            memo[nums.Length] = memo[nums.Length] > sum ? memo[nums.Length] : sum;
            return;
        }

        // already visited with bigger sum
        if (memo[idx] >= sum)
        {
            return;
        }

        memo[idx] = memo[idx] > sum ? memo[idx] : sum;
        sum += nums[idx];
        // skip 1 house
        Rob(nums, memo, idx + 2, sum, endIdx);
        // skip 2 houses
        Rob(nums, memo, idx + 3, sum, endIdx);
    }
}