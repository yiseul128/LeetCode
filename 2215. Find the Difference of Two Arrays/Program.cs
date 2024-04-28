public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        IList<IList<int>> answer = new List<IList<int>>();
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();

        // build sets
        HashSet<int> set1 = new HashSet<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            set1.Add(nums1[i]);
        }

        HashSet<int> set2 = new HashSet<int>();
        for (int i = 0; i < nums2.Length; i++)
        {
            set2.Add(nums2[i]);
        }

        // find distinct
        foreach (int i in set1)
        {
            if (!set2.Contains(i))
            {
                list1.Add(i);
            }
        }

        foreach (int i in set2)
        {
            if (!set1.Contains(i))
            {
                list2.Add(i);
            }
        }

        answer.Add(list1);
        answer.Add(list2);

        return answer;
    }
}