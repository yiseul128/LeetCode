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

            // ListNode n = newHead;
            // while(n!= null){
            //     Console.WriteLine(n.val);
            //     n = n.next;
            // }

            return newHead;
        }
    }
}
