public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        int prevSum = 0;
        int currSum = 0;
        bool isPrev0 = false;
        int longest = 0;
        bool found0 = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                found0 = true;
                // add with prev chunk
                if (!isPrev0)
                {
                    if (prevSum > 0)
                    {
                        int sum = prevSum + currSum;
                        longest = longest > sum ? longest : sum;
                    }
                    else
                    {
                        longest = longest > currSum ? longest : currSum;
                    }
                    prevSum = currSum;
                }
                else
                {
                    // reset because 0s in the middle is 2 or more
                    prevSum = 0;
                }
                isPrev0 = true;
                currSum = 0;
            }
            // add 1s 
            else
            {
                currSum++;
                isPrev0 = false;
            }
        }

        Console.WriteLine(currSum);
        // deal with last chunk of 1s
        if (!isPrev0)
        {
            if (prevSum > 0)
            {
                int sum = prevSum + currSum;
                longest = longest > sum ? longest : sum;
            }
        }

        if (longest == 0)
        {
            // deal with only 0s
            if (currSum == 0)
            {
                return 0;
            }

            // deal with only 1s
            if (prevSum < 1)
            {
                if (found0)
                {
                    return currSum;
                }
                return currSum - 1;
            }
        }

        return longest;
    }
}