public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int[] minSums = new int[cost.Length];
        for (int i = 0; i < minSums.Length; i++)
        {
            minSums[i] = Int32.MaxValue;
        }
        int min1 = RecurClimbing(cost, 0, 0, minSums);

        for (int i = 0; i < minSums.Length; i++)
        {
            minSums[i] = Int32.MaxValue;
        }
        int min2 = RecurClimbing(cost, 1, 0, minSums);
        return min1 < min2 ? min1 : min2;
    }

    public int RecurClimbing(int[] cost, int idx, int sum, int[] minSums)
    {
        if (idx == cost.Length - 1)
        {
            return sum + cost[idx];
        }

        int currMin = Int32.MaxValue;
        sum += cost[idx];

        if (idx + 2 < cost.Length)
        {
            int sum2 = Int32.MaxValue;
            if (minSums[idx + 2] == Int32.MaxValue)
            {
                sum2 = RecurClimbing(cost, idx + 2, sum, minSums);
            }
            else
            {
                sum2 = sum + minSums[idx + 2];
            }

            currMin = currMin < sum2 ? currMin : sum2;
        }
        else
        {
            currMin = currMin < sum ? currMin : sum;
        }

        if (idx + 1 < cost.Length)
        {
            int sum1 = Int32.MaxValue;
            if (minSums[idx + 1] == Int32.MaxValue)
            {
                sum1 = RecurClimbing(cost, idx + 1, sum, minSums);
            }
            else
            {
                sum1 = sum + minSums[idx + 1];
            }

            currMin = currMin < sum1 ? currMin : sum1;
        }

        sum -= cost[idx];
        minSums[idx] = minSums[idx] < currMin - sum ? minSums[idx] : currMin - sum;
        return currMin;
    }
}