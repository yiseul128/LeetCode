public class Solution
{
    public int MaxUncrossedLines(int[] nums1, int[] nums2)
    {
        int[,] memo = new int[nums1.Length, nums2.Length];
        return RecurUncrossedLines(nums1, nums2, 0, 0, 0, memo);
    }

    public int RecurUncrossedLines(int[] nums1, int[] nums2, int idx1, int idx2, int count, int[,] memo)
    {
        if (idx1 >= nums1.Length || idx2 >= nums2.Length)
        {
            return count;
        }

        if (memo[idx1, idx2] != 0)
        {
            return count + memo[idx1, idx2];
        }

        // match idx2
        int max = 0, newCount = 0;
        for (int i = idx1; i < nums1.Length; i++)
        {
            if (nums1[i] == nums2[idx2])
            {
                max = RecurUncrossedLines(nums1, nums2, i + 1, idx2 + 1, count + 1, memo);
                break;
            }
        }

        // match idx1
        for (int i = idx2; i < nums2.Length; i++)
        {
            if (nums2[i] == nums1[idx1])
            {
                newCount = RecurUncrossedLines(nums1, nums2, idx1 + 1, i + 1, count + 1, memo);
                max = max > newCount ? max : newCount;
                break;
            }
        }

        newCount = RecurUncrossedLines(nums1, nums2, idx1 + 1, idx2 + 1, count, memo);
        max = max > newCount ? max : newCount;

        memo[idx1, idx2] = max - count;

        return max;
    }
}