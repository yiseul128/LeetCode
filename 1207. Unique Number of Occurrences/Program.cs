public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> nums = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (nums.ContainsKey(arr[i]))
            {
                nums[arr[i]]++;
            }
            else
            {
                nums.Add(arr[i], 1);
            }
        }

        HashSet<int> uniqueCounts = new HashSet<int>();
        foreach (var item in nums)
        {
            if (uniqueCounts.Contains(item.Value))
            {
                return false;
            }

            uniqueCounts.Add(item.Value);
        }

        return true;
    }
}