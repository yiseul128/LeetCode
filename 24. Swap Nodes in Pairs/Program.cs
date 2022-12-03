using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Swap_Nodes_in_Pairs
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
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode n1 = head;
            if (n1 == null)
            {
                return head;
            }

            ListNode n2 = head.next;
            if (n2 == null)
            {
                return head;
            }

            ListNode newHead = n2;

            ListNode n0 = null;
            while (n2 != null)
            {
                //Console.WriteLine(n1.val + ", " + n2.val );
                // swap
                n1.next = n2.next;
                n2.next = n1;
                if (n0 != null)
                {
                    n0.next = n2;
                }

                // walk
                n0 = n1;
                n1 = n1.next;
                if (n1 != null)
                {
                    n2 = n1.next;
                }
                else
                {
                    n2 = null;
                }
            }

            return newHead;
        }
    }
}
