public class Solution
{
    public int LenLongestFibSubseq(int[] arr)
    {
        int arrN = arr.Length;
        int longest = 0;

        for (int i1 = 0; i1 < arrN - 2; i1++)
        {
            for (int i2 = i1 + 1; i2 < arrN - 1; i2++)
            {
                int foundIdx = Search(arr, arr[i1] + arr[i2], i2 + 1);
                if (foundIdx != -1)
                {
                    int count = 3;
                    int x1 = arr[i2];
                    int x2 = arr[foundIdx];

                    while (true)
                    {
                        foundIdx = Search(arr, x1 + x2, foundIdx + 1);
                        if (foundIdx == -1)
                        {
                            break;
                        }
                        count++;
                        x1 = x2;
                        x2 = arr[foundIdx];
                    }

                    if (count > longest)
                    {
                        longest = count;
                    }
                }
            }
        }

        return longest;
    }

    public int Search(int[] arr, int target, int startIdx)
    {
        int endIdx = arr.Length - 1;

        while (startIdx <= endIdx && startIdx >= 0 && endIdx < arr.Length)
        {
            int mid = (startIdx + endIdx) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }

            if (arr[mid] > target)
            {
                endIdx = mid - 1;
            }
            else
            {
                startIdx = mid + 1;
            }
        }

        return -1;
    }
}