public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        IList<bool> isGreatest = new List<bool>();

        // find existing greatest
        int greatestIdx = 0;
        for (int i = 1; i < candies.Length; i++)
        {
            greatestIdx = candies[greatestIdx] > candies[i] ? greatestIdx : i;
        }

        // find out by comparing existing greatest and ith + extra
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[greatestIdx] <= candies[i] + extraCandies)
            {
                isGreatest.Add(true);
            }
            else
            {
                isGreatest.Add(false);
            }
        }

        return isGreatest;
    }
}