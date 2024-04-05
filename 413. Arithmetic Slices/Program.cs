public class Solution
{
    public int NumberOfArithmeticSlices(int[] nums)
    {
        if (nums.Length < 3)
        {
            return 0;
        }

        int answer = 0;
        int d = nums[1] - nums[0];
        int count = 2;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            int newD = nums[i + 1] - nums[i];
            if (newD == d)
            {
                count++;
            }
            else
            {
                d = newD;
                answer += CalculateSlices(count);
                count = 2;
            }
        }
        answer += CalculateSlices(count);

        return answer;
    }

    public int CalculateSlices(int count)
    {
        int nOfSlices = 0;
        for (int i = 3; i <= count; i++)
        {
            nOfSlices += (count - i + 1);
        }

        return nOfSlices;
    }
}