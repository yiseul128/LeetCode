using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _143.Reorder_List
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
        public void ReorderList(ListNode head)
        {
            ListNode front = head;
            ListNode back = head;
            ListNode frontTemp = null;
            ListNode backTemp = null;

            if (head.next == null)
            {
                return;
            }

            Stack nodes = new Stack();
            while (back != null)
            {
                nodes.Push(back);
                back = back.next;
            }

            back = (ListNode)nodes.Pop();
            while (front.next != null && front.next != back)
            {
                frontTemp = front.next;
                backTemp = (ListNode)nodes.Pop();

                front.next = back;
                back.next = frontTemp;
                backTemp.next = null;

                front = frontTemp;
                back = backTemp;
            }

        }
    }
}
