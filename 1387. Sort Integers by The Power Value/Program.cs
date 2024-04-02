public class Solution
{
    public int GetKth(int lo, int hi, int k)
    {
        SortedDictionary<int, List<int>> sortedByPower = new SortedDictionary<int, List<int>>();
        for (int i = lo; i <= hi; i++)
        {
            int power = CalculatePower(i, 0);
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
        return 0;
    }

    public int CalculatePower(int x, int step)
    {
        if (x == 1)
        {
            return step;
        }

        if (x % 2 == 0)
        {
            return CalculatePower(x / 2, step + 1);
        }
        else
        {
            return CalculatePower(3 * x + 1, step + 1);
        }
    }
}