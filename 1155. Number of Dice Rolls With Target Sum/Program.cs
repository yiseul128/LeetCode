public class Solution
{
    private int mod = Convert.ToInt32(Math.Pow(10, 9)) + 7;

    public int NumRollsToTarget(int n, int k, int target)
    {
        int[,] memo = new int[n, target];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < target; j++)
            {
                memo[i, j] = -1;
            }
        }

        return RecurNumRollsToTarget(n, k, target, 0, 0, memo);
    }

    public int RecurNumRollsToTarget(int n, int k, int target, int currSum, int diceCount, int[,] memo)
    {
        // target match
        if (diceCount == n && currSum == target)
        {
            return 1;
        }

        // all diced used || over target 
        if (diceCount == n || currSum >= target)
        {
            return 0;
        }

        if (memo[diceCount, currSum] != -1)
        {
            return memo[diceCount, currSum];
        }

        int count = 0;
        // recur
        for (int i = 1; i <= k; i++)
        {
            count = (count + RecurNumRollsToTarget(n, k, target, currSum + i, diceCount + 1, memo)) % mod;
        }
        memo[diceCount, currSum] = count % mod;
        return memo[diceCount, currSum];
    }
}