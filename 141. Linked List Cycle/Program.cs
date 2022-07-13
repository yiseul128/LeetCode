using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141.Linked_List_Cycle
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
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            ListNode n = new ListNode(0);

            ListNode curNode = null;
            while (head != null)
            {
                curNode = head;
                head = head.next;
                if (curNode.next == n)
                {
                    return true;
                }
                curNode.next = n; //set it
            }
            return false;
        }
    }
}
