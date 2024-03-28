public class Solution
{
    public long GetDescentPeriods(int[] prices)
    {
        int smoothCount = 1;
        long answer = 1;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i - 1] - prices[i] == 1)
            {
                smoothCount++;
            }
            else
            {
                smoothCount = 1;
            }
            answer += smoothCount;
        }
        return answer;
    }
}