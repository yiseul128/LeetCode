public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        double maxSum = sum;
        int end = k;
        while (end < nums.Length)
        {
            sum -= nums[end - k];
            sum += nums[end];
            end++;
            maxSum = maxSum > sum ? maxSum : sum;
        }
        return maxSum / k;
    }
}