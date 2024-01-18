Solution s = new Solution();
int[] a = { 0, 1, 2, 1, 2 };
Console.WriteLine(s.RemoveElement(a, 2));

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[count] = nums[i];
                count++;
            }
        }

        return count;
    }
}