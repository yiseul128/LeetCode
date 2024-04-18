public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0)
        {
            return true;
        }

        int emptyCount = 1; // consider left of (0)th as empty
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0)
            {
                emptyCount++;
            }
            else if (emptyCount > 0)
            {
                if (emptyCount % 2 == 0)
                {
                    emptyCount--;
                }
                n -= emptyCount / 2;
                emptyCount = 0;
            }

            if (n <= 0)
            {
                return true;
            }
        }

        if (emptyCount > 0)
        {
            emptyCount++; // consider right of (n-1)th as empty
            if (emptyCount % 2 == 0)
            {
                emptyCount--;
            }
            n -= emptyCount / 2;
        }

        if (n <= 0)
        {
            return true;
        }
        return false;
    }
}