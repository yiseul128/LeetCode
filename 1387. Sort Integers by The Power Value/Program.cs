public class Solution
{
    public int GetKth(int lo, int hi, int k)
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();
        SortedDictionary<int, List<int>> sortedByPower = new SortedDictionary<int, List<int>>();
        for (int i = lo; i <= hi; i++)
        {
            int power = CalculatePower(i, 0, memo);
            if (sortedByPower.ContainsKey(power))
            {
                sortedByPower[power].Add(i);
            }
            else
            {
                List<int> newList = new List<int>();
                newList.Add(i);
                sortedByPower.Add(power, newList);
            }
        }

        int answer = 0;
        foreach (var item in sortedByPower)
        {
            List<int> list = item.Value;

            if (k <= list.Count)
            {
                foreach (int i in list)
                {
                    k--;
                    if (k == 0)
                    {
                        return i;
                    }
                }
            }
            else
            {
                k -= list.Count;
            }
        }
        return answer;
    }

    public int CalculatePower(int x, int step, Dictionary<int, int> memo)
    {
        if (x == 1)
        {
            return step;
        }

        if (memo.ContainsKey(x))
        {
            return step + memo[x];
        }

        int power = 0;
        if (x % 2 == 0)
        {
            power = CalculatePower(x / 2, step + 1, memo);
        }
        else
        {
            power = CalculatePower(3 * x + 1, step + 1, memo);
        }
        memo.Add(x, power - step);
        return power;
    }
}