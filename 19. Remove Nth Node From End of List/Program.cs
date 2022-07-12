using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Remove_Nth_Node_From_End_of_List
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            ListNode curNode = head;

            ListNode[] nodes = new ListNode[30];

            int count = 0;
            while (curNode != null)
            {
                nodes[count] = curNode;
                curNode = curNode.next;
                count++;
            }


            if (n == count)
            {
                //if first one
                head = head.next;
            }
            else
            {
                //regular case
                nodes[count - n - 1].next = nodes[count - n + 1];
            }
            return head;
        }
    }
}
