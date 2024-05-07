/* Definition for singly-linked list. */
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public int PairSum(ListNode head)
    {
        ListNode walk = head;
        int count = 0;
        while (walk != null)
        {
            walk = walk.next;
            count++;
        }

        int half = count / 2;
        int[] firstHalfArr = new int[half];
        int max = Int32.MinValue;
        for (int i = 0; i < count; i++)
        {
            if (half > i)
            {
                firstHalfArr[i] = head.val;
            }
            else
            {
                int sum = head.val + firstHalfArr[count - 1 - i];
                max = sum > max ? sum : max;
            }
            head = head.next;
        }
        return max;
    }
}