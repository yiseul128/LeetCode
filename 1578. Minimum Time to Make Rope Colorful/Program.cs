public class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        int cost = 0;

        int idx = 1;
        int maxTimeIdx = -1;
   
        int timeUsed = neededTime[0];
        while (idx < colors.Length)
        {
            if (colors[idx] == colors[idx - 1])
            {
                if (maxTimeIdx == -1)
                {
                    maxTimeIdx = neededTime[idx] > neededTime[idx - 1] ? idx : idx - 1;
                }
                else
                {
                    maxTimeIdx = neededTime[idx] > neededTime[maxTimeIdx] ? idx : maxTimeIdx;
                }
                timeUsed += neededTime[idx];
            }
            else
            {
                if (maxTimeIdx != -1)
                {
                    cost += timeUsed - neededTime[maxTimeIdx];
                }

                timeUsed = neededTime[idx];
                maxTimeIdx = -1;
            }
            idx++;
        }

        if (maxTimeIdx != -1)
        {
            cost += timeUsed - neededTime[maxTimeIdx];
        }

        return cost;
    }

}