using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Reverse_Nodes_in_k_Group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(3);
            ListNode n4 = new ListNode(4);
            ListNode n5 = new ListNode(5);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4; 
            n4.next = n5;

            Solution s = new Solution();
            ListNode listNode = s.ReverseKGroup(n1, 2);
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
        public ListNode RecursiveReverse(ListNode head, ListNode prevEnd, int k, int count)
        {
            // check if possible
            if (count == 0)
            {
                return head;
            }

            // reverse one unit
            ListNode prev = null;
            ListNode curr = head;
            ListNode tmpNext = null;
            for (int j = 0; j < k; j++)
            {
                tmpNext = curr.next;
                curr.next = prev;
                prev = curr;
                curr = tmpNext;
            }

            head.next = curr;
            if (prevEnd != null)
            {
                prevEnd.next = prev;
            }

            // recurr 
            RecursiveReverse(curr, head, k, --count);

            // return head
            return prev;
        }

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            // traverse to get count
            ListNode walk = head;

            int len = 0;
            while (walk != null)
            {
                walk = walk.next;
                len++;
            }

            return RecursiveReverse(head, null, k, len / k);

            // iterative solution
            /* 
            int count = len / k;

            // loop 
            bool headFound = false;
            ListNode newHead = head;
            ListNode prevEnd = null;
            ListNode currEnd = null;
            ListNode prev = null;
            ListNode curr = head;
            ListNode tmpNext = null;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    tmpNext = curr.next;

                    // first
                    if (j == 0)
                    {
                        currEnd = curr;
                    }
                    else
                    {
                        curr.next = prev;

                        // last
                        if (j == k - 1)
                        {
                            if (prevEnd != null)
                            {
                                prevEnd.next = curr;
                            }
                            prevEnd = currEnd;

                            if (!headFound)
                            {
                                newHead = curr;
                                headFound = true;
                            }
                        }
                    }
                    prev = curr;
                    curr = tmpNext;
                }
            }
            currEnd.next = curr;

            return newHead;
            */
        }
    }
}
