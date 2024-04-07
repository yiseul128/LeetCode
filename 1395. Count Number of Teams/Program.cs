public class Solution
{
    public int NumTeams(int[] rating)
    {
        int[] countHigher = new int[rating.Length];
        int[] countLower = new int[rating.Length];

        for (int i = 1; i < rating.Length - 1; i++)
        {
            int countSame = 0;
            for (int j = i + 1; j < rating.Length; j++)
            {
                if (rating[i] < rating[j])
                {
                    countHigher[i]++;
                }
                else if (rating[i] == rating[j])
                {
                    countSame++;
                }
            }
            countLower[i] = rating.Length - countHigher[i] - countSame - i - 1;
        }

        int answer = 0;
        for (int i = 0; i < rating.Length - 2; i++)
        {
            for (int j = i + 1; j < rating.Length - 1; j++)
            {
                if (rating[i] < rating[j])
                {
                    answer += countHigher[j];
                }
                if (rating[i] > rating[j])
                {
                    answer += countLower[j];
                }
            }
        }

        return answer;
    }
}