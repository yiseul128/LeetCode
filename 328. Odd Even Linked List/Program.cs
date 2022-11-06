using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _328.Odd_Even_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /* Definition for singly-linked list.  */
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
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            ListNode odd = head;

            ListNode even, evenHead;
            if (head.next != null)
            {
                even = head.next;
                evenHead = head.next;
            }
            else
            {
                return head;
            }

            ListNode curNode;
            if (even.next != null)
            {
                curNode = even.next; // odd
            }
            else
            {
                return head;
            }

            bool isOdd = true;
            while (curNode != null)
            {
                if (isOdd)
                {
                    odd.next = curNode;
                    odd = odd.next;
                }
                else
                {
                    even.next = curNode;
                    even = even.next;
                }
                curNode = curNode.next;
                isOdd = !isOdd;
            }

            odd.next = evenHead;
            even.next = null;

            return head;
        }
    }
}
