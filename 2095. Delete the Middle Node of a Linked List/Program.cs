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
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head.next == null)
        {
            return null;
        }

        ListNode prevMiddle = head;
        ListNode middle = head.next;
        ListNode walk = head.next;
        bool moveMiddle = false;
        while (walk.next != null)
        {
            if (moveMiddle)
            {
                prevMiddle = middle;
                middle = middle.next;
            }
            walk = walk.next;
            moveMiddle = !moveMiddle;
        }
        prevMiddle.next = middle.next;
        return head;
    }
}