using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Add_Two_Numbers
{
    class Program
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
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode head = new ListNode();
            ListNode curr = head;

            while (true)
            {
                if (l2 != null)
                {
                    curr.val += l2.val;
                    l2 = l2.next;
                }
                if (l1 != null)
                {
                    curr.val += l1.val;
                    l1 = l1.next;
                }

                if (l1 == null && l2 == null)
                {
                    break;
                }

                // deal with carry
                if (curr.val > 9)
                {
                    curr.val = curr.val % 10;
                    curr.next = new ListNode(1);
                }
                else
                {
                    curr.next = new ListNode();
                }
                curr = curr.next;
            }

            if (curr.val > 9)
            {
                curr.val %= 10;
                curr.next = new ListNode(1);
            }

            return head;
        }
    }
}
