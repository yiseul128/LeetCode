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

            bool over = false;

            ListNode head = new ListNode();
            ListNode curr = head;

            while (true)
            {
                if (over)
                {
                    curr.val = 1;
                    over = false;
                }

                int tmp = curr.val;
                if (l1 == null)
                {
                    tmp += l2.val;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    tmp += l1.val;
                    l1 = l1.next;
                }
                else
                {
                    tmp += l1.val + l2.val;
                    l1 = l1.next;
                    l2 = l2.next;
                }

                if (tmp > 9)
                {
                    over = true;
                    curr.val = tmp % 10;
                }
                else
                {
                    curr.val = tmp;
                }

                if (l1 == null && l2 == null)
                {
                    break;
                }

                curr.next = new ListNode();
                curr = curr.next;

            }

            if (over)
            {
                curr.next = new ListNode();
                curr = curr.next;
                curr.val = 1;
            }

            return head;
        }
    }
}
