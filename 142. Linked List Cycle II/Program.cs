using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142.Linked_List_Cycle_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    /* Definition for singly-linked list. */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
 
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();

            while (head != null)
            {
                if (set.Contains(head.next))
                {
                    return head.next;
                }
                set.Add(head);
                head = head.next;
            }
            return null;
        }
    }
}
