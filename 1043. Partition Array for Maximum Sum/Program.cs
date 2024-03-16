public class Solution
{
    public int MaxSumAfterPartitioning(int[] arr, int k)
    {
        int[] memo = new int[arr.Length];
        return RecurPartitioning(arr, k, 0, 0, 0, 0, memo);
    }

    public int RecurPartitioning(int[] arr, int k, int idx, int count, int maxInPartition, int sum, int[] memo)
    {
        if (idx == arr.Length)
        {
            sum += maxInPartition * count;
            return sum;
        }

        int maxSum = 0;
        maxInPartition = maxInPartition > arr[idx] ? maxInPartition : arr[idx];
        count++;

        // partition here
        int sumByPartitioningHere = sum + maxInPartition * count;
        if (idx + 1 < arr.Length && memo[idx + 1] != 0)
        {
            maxSum = sumByPartitioningHere + memo[idx + 1];
        }
        else
        {
            int newSum = RecurPartitioning(arr, k, idx + 1, 0, 0, sumByPartitioningHere, memo);
            maxSum = newSum;
            if (idx + 1 < arr.Length)
            {
                memo[idx + 1] = newSum - sumByPartitioningHere;
            }
        }

        // go further without partitioning
        if (k > count)
        {
            int newSum2 = RecurPartitioning(arr, k, idx + 1, count, maxInPartition, sum, memo);
            maxSum = maxSum > newSum2 ? maxSum : newSum2;
        }
        return maxSum;
    }
}